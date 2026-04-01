using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace Firma {
  public partial class Form1:Form {
    private string aktywnaTabela = "";

    public Form1() {
      InitializeComponent();

      this.FormClosing += Form1_FormClosing;

      klienciBindingSource.ListChanged += KlienciBindingSource_ListChanged;
      pracownicyBindingSource.ListChanged += PracownicyBindingSource_ListChanged;

      btnSzukaj.Click += btnSzukaj_Click;
      btnReset.Click += btnReset_Click;
      txtSzukaj.KeyDown += txtSzukaj_KeyDown;

      klienciDataGridView.CellEnter += klienciDataGridView_CellEnter;
      pracownicyDataGridView.CellEnter += pracownicyDataGridView_CellEnter;
      }

    private void Form1_Load(object sender,EventArgs e) {
      this.klienciTableAdapter.Fill(this.firmaDataSet.Klienci);
      this.pracownicyTableAdapter.Fill(this.firmaDataSet.Pracownicy);

      if(klienciDataGridView.Columns.Contains("IdKlienta"))
        klienciDataGridView.Columns["IdKlienta"].Visible = false;

      if(pracownicyDataGridView.Columns.Contains("IdPracownika"))
        pracownicyDataGridView.Columns["IdPracownika"].Visible = false;

      AktualizujTytul();
      }

    private void Form1_FormClosing(object sender,FormClosingEventArgs e) {
      if(!ZapiszZmiany()) {
        e.Cancel = true;
        }
      }

    private void klienciDataGridView_CellEnter(object sender,DataGridViewCellEventArgs e) {
      aktywnaTabela = "Klienci";
      }

    private void pracownicyDataGridView_CellEnter(object sender,DataGridViewCellEventArgs e) {
      aktywnaTabela = "Pracownicy";
      }

    private void btnUsun_Click(object sender,EventArgs e) {
      if(aktywnaTabela == "Klienci" && klienciBindingSource.Current != null) {
        DialogResult wynik = MessageBox.Show(
            "Czy na pewno chcesz usunąć klienta?",
            "Potwierdzenie",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if(wynik != DialogResult.Yes)
          return;

        try {
          klienciBindingSource.RemoveCurrent();

          if(ZapiszZmiany()) {
            AktualizujTytul();

            MessageBox.Show(
                "Klient został usunięty i zapisany w bazie danych.",
                "Sukces",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            }
          } catch(Exception ex) {
          MessageBox.Show(
              "Błąd podczas usuwania klienta:\n" + ex.Message,
              "Błąd",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error
          );
          }

        return;
        }

      if(aktywnaTabela == "Pracownicy" && pracownicyBindingSource.Current != null) {
        DialogResult wynik = MessageBox.Show(
            "Czy na pewno chcesz usunąć pracownika?",
            "Potwierdzenie",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if(wynik != DialogResult.Yes)
          return;

        try {
          pracownicyBindingSource.RemoveCurrent();

          if(ZapiszZmiany()) {
            AktualizujTytul();

            MessageBox.Show(
                "Pracownik został usunięty i zapisany w bazie danych.",
                "Sukces",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            }
          } catch(Exception ex) {
          MessageBox.Show(
              "Błąd podczas usuwania pracownika:\n" + ex.Message,
              "Błąd",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error
          );
          }

        return;
        }

      MessageBox.Show(
          "Nie wybrano rekordu do usunięcia.",
          "Informacja",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information
      );
      }

    private void btnSzukaj_Click(object sender,EventArgs e) {
      ZastosujFiltr();
      }

    private void txtSzukaj_KeyDown(object sender,KeyEventArgs e) {
      if(e.KeyCode == Keys.Enter) {
        ZastosujFiltr();
        e.SuppressKeyPress = true;
        } else if(e.KeyCode == Keys.Escape) {
        btnReset_Click(sender,e);
        }
      }

    private void btnReset_Click(object sender,EventArgs e) {
      txtSzukaj.Clear();

      klienciBindingSource.RemoveFilter();
      pracownicyBindingSource.RemoveFilter();

      AktualizujTytul();
      txtSzukaj.Focus();
      }

    private void txtSzukaj_TextChanged(object sender,EventArgs e) {
      ZastosujFiltr();
      }

    private void klienciBindingNavigatorSaveItem_Click(object sender,EventArgs e) {
      if(ZapiszZmiany()) {
        MessageBox.Show(
            "Zmiany zostały zapisane.",
            "Zapis",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
        }
      }

    private void KlienciBindingSource_ListChanged(object sender,ListChangedEventArgs e) {
      AktualizujTytul();
      }

    private void PracownicyBindingSource_ListChanged(object sender,ListChangedEventArgs e) {
      AktualizujTytul();
      }

    private void AktualizujTytul() {
      this.Text = $"Firma – liczba klientów: {klienciBindingSource.Count} | liczba pracowników: {pracownicyBindingSource.Count}";
      }

    private void ZastosujFiltr() {
      string tekst = txtSzukaj.Text.Trim().Replace("'","''");

      if(string.IsNullOrWhiteSpace(tekst)) {
        klienciBindingSource.RemoveFilter();
        pracownicyBindingSource.RemoveFilter();
        } else {
        klienciBindingSource.Filter =
            $"Imie LIKE '%{tekst}%' OR " +
            $"Nazwisko LIKE '%{tekst}%' OR " +
            $"Miasto LIKE '%{tekst}%' OR " +
            $"Telefon LIKE '%{tekst}%'";

        pracownicyBindingSource.Filter =
            $"Imie LIKE '%{tekst}%' OR " +
            $"Nazwisko LIKE '%{tekst}%' OR " +
            $"Stanowisko LIKE '%{tekst}%'";
        }

      AktualizujTytul();
      }

    private bool ZapiszZmiany() {
      try {
        this.Validate();

        this.klienciBindingSource.EndEdit();
        this.pracownicyBindingSource.EndEdit();

        if(!WalidujDane())
          return false;

        this.klienciTableAdapter.Update(this.firmaDataSet.Klienci);
        this.pracownicyTableAdapter.Update(this.firmaDataSet.Pracownicy);

        return true;
        } catch(Exception ex) {
        MessageBox.Show(
            "Błąd podczas zapisu danych:\n" + ex.Message,
            "Błąd",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        );
        return false;
        }
      }

    private bool WalidujKlientow() {
      StringBuilder bledy = new StringBuilder();

      foreach(FirmaDataSet.KlienciRow row in firmaDataSet.Klienci) {
        if(row.RowState == System.Data.DataRowState.Deleted)
          continue;

        string imie = row.IsImieNull() ? "" : row.Imie;
        string nazwisko = row.IsNazwiskoNull() ? "" : row.Nazwisko;
        string miasto = row.IsMiastoNull() ? "" : row.Miasto;
        string telefon = row.IsTelefonNull() ? "" : row.Telefon;

        if(string.IsNullOrWhiteSpace(imie))
          bledy.AppendLine("Klient: imię nie może być puste.");

        if(string.IsNullOrWhiteSpace(nazwisko))
          bledy.AppendLine("Klient: nazwisko nie może być puste.");

        if(string.IsNullOrWhiteSpace(miasto))
          bledy.AppendLine("Klient: miasto nie może być puste.");

        if(string.IsNullOrWhiteSpace(telefon)) {
          bledy.AppendLine("Klient: telefon nie może być pusty.");
          } else {
          foreach(char znak in telefon) {
            if(!char.IsDigit(znak)) {
              bledy.AppendLine("Klient: telefon może zawierać tylko cyfry.");
              break;
              }
            }
          }
        }

      if(bledy.Length > 0) {
        MessageBox.Show(
            bledy.ToString(),
            "Błędy danych klientów",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        );
        return false;
        }

      return true;
      }

    private bool WalidujPracownikow() {
      StringBuilder bledy = new StringBuilder();

      foreach(FirmaDataSet.PracownicyRow row in firmaDataSet.Pracownicy) {
        if(row.RowState == System.Data.DataRowState.Deleted)
          continue;

        string imie = row.IsImieNull() ? "" : row.Imie;
        string nazwisko = row.IsNazwiskoNull() ? "" : row.Nazwisko;
        string stanowisko = row.IsStanowiskoNull() ? "" : row.Stanowisko;

        if(string.IsNullOrWhiteSpace(imie))
          bledy.AppendLine("Pracownik: imię nie może być puste.");

        if(string.IsNullOrWhiteSpace(nazwisko))
          bledy.AppendLine("Pracownik: nazwisko nie może być puste.");

        if(string.IsNullOrWhiteSpace(stanowisko))
          bledy.AppendLine("Pracownik: stanowisko nie może być puste.");

        if(row.IsPensjaNull() || row.Pensja <= 0)
          bledy.AppendLine("Pracownik: pensja musi być większa od 0.");
        }

      if(bledy.Length > 0) {
        MessageBox.Show(
            bledy.ToString(),
            "Błędy danych pracowników",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        );
        return false;
        }

      return true;
      }

    private bool WalidujDane() {
      bool klienciOk = WalidujKlientow();
      bool pracownicyOk = WalidujPracownikow();

      return klienciOk && pracownicyOk;
      }
    }
  }
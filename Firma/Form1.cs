using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
      txtSzukaj.KeyDown += txtSzukaj_KeyDown;
      btnReset.Click += btnReset_Click;
      btnNiezaplacone.Click += btnNiezaplacone_Click;
      btnFakturyDostawcy.Click += btnFakturyDostawcy_Click;
      btnWszystkieFaktury.Click += btnWszystkieFaktury_Click;

      klienciDataGridView.CellEnter += klienciDataGridView_CellEnter;
      pracownicyDataGridView.CellEnter += pracownicyDataGridView_CellEnter;
      kontrahenciDataGridView.CellEnter += kontrahenciDataGridView_CellEnter;
      fakturyDataGridView.CellEnter += fakturyDataGridView_CellEnter;
      fakturyDataGridView.CellFormatting += fakturyDataGridView_CellFormatting;
      }

    private void Form1_Load(object sender,EventArgs e) {
      this.klienciTableAdapter.Fill(this.firmaDataSet.Klienci);
      this.pracownicyTableAdapter.Fill(this.firmaDataSet.Pracownicy);
      this.fakturySprzedazyTableAdapter.Fill(this.firmaDataSet.FakturySprzedazy);
      this.kontrahenciTableAdapter.Fill(this.firmaDataSet1.Kontrahenci);

      if(klienciDataGridView.Columns.Contains("IdKlienta"))
        klienciDataGridView.Columns["IdKlienta"].Visible = false;

      if(pracownicyDataGridView.Columns.Contains("IdPracownika"))
        pracownicyDataGridView.Columns["IdPracownika"].Visible = false;

      if(kontrahenciDataGridView.Columns.Contains("Id"))
        kontrahenciDataGridView.Columns["Id"].Visible = false;

      if(fakturyDataGridView.Columns.Contains("Id"))
        fakturyDataGridView.Columns["Id"].Visible = false;

      if(fakturyDataGridView.Columns.Count > 7) {
        fakturyDataGridView.Columns[1].HeaderText = "Numer faktury";
        fakturyDataGridView.Columns[2].HeaderText = "Kwota netto";
        fakturyDataGridView.Columns[3].HeaderText = "VAT";
        fakturyDataGridView.Columns[4].HeaderText = "Data";
        fakturyDataGridView.Columns[5].HeaderText = "Zapłacono";
        fakturyDataGridView.Columns[6].HeaderText = "Kontrahent ID";
        fakturyDataGridView.Columns[7].HeaderText = "Pracownik ID";
        }

      this.BackColor = Color.FromArgb(245,247,250);

      StylizujGrid(klienciDataGridView);
      StylizujGrid(pracownicyDataGridView);
      StylizujGrid(kontrahenciDataGridView);
      StylizujGrid(fakturyDataGridView);

      StylizujPrzycisk(btnNiezaplacone);
      StylizujPrzycisk(btnFakturyDostawcy);
      StylizujPrzycisk(btnWszystkieFaktury);
      StylizujPrzycisk(btnUsun);
      StylizujPrzycisk(btnSzukaj);
      StylizujPrzycisk(btnReset);

      DodajEfektHover(btnNiezaplacone);
      DodajEfektHover(btnFakturyDostawcy);
      DodajEfektHover(btnWszystkieFaktury);
      DodajEfektHover(btnUsun);
      DodajEfektHover(btnReset);

      StylizujGlownyPrzycisk(btnSzukaj);
      DodajEfektHoverGlowny(btnSzukaj);

      DodajEfektFocus(txtSzukaj);

      StylizujLabelSekcji(labelKlienci);
      StylizujLabelSekcji(labelPracownicy);
      StylizujLabelSekcji(labelKontrahenci);
      StylizujLabelSekcji(labelFaktury);

      UstawAktywnaSekcje(labelKlienci);

      AktualizujTytul();
      }
    private void Form1_FormClosing(object sender,FormClosingEventArgs e) {
      if(!ZapiszZmiany()) {
        e.Cancel = true;
        }
      }
    private void klienciDataGridView_CellEnter(object sender,DataGridViewCellEventArgs e) {
      aktywnaTabela = "Klienci";
      UstawAktywnaSekcje(labelKlienci);
      }
    private void pracownicyDataGridView_CellEnter(object sender,DataGridViewCellEventArgs e) {
      aktywnaTabela = "Pracownicy";
      UstawAktywnaSekcje(labelPracownicy);
      }
    private void kontrahenciDataGridView_CellEnter(object sender,DataGridViewCellEventArgs e) {
      aktywnaTabela = "Kontrahenci";
      UstawAktywnaSekcje(labelKontrahenci);
      }
    private void fakturyDataGridView_CellEnter(object sender,DataGridViewCellEventArgs e) {
      aktywnaTabela = "Faktury";
      UstawAktywnaSekcje(labelFaktury);
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
      kontrahenciBindingSource.RemoveFilter();
      fakturyBindingSource.RemoveFilter();

      fakturyDataGridView.DataSource = fakturyBindingSource;
      fakturyDataGridView.Refresh();

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
      this.Text = $"Firma – system obsługi danych | Klienci: {klienciBindingSource.Count} | Pracownicy: {pracownicyBindingSource.Count}";
      }

    private void ZastosujFiltr() {
      string tekst = txtSzukaj.Text.Trim().Replace("'","''");

      if(string.IsNullOrWhiteSpace(tekst)) {
        klienciBindingSource.RemoveFilter();
        pracownicyBindingSource.RemoveFilter();
        kontrahenciBindingSource.RemoveFilter();
        fakturyBindingSource.RemoveFilter();

        fakturyDataGridView.DataSource = fakturyBindingSource;
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

        kontrahenciBindingSource.Filter =
            $"Nazwa LIKE '%{tekst}%' OR " +
            $"Nip LIKE '%{tekst}%' OR " +
            $"Ulica LIKE '%{tekst}%' OR " +
            $"Miasto LIKE '%{tekst}%'";

        fakturyBindingSource.Filter =
            $"Numer LIKE '%{tekst}%' OR " +
            $"Convert(Netto, 'System.String') LIKE '%{tekst}%' OR " +
            $"Convert(Vat, 'System.String') LIKE '%{tekst}%' OR " +
            $"Convert(Zaplacono, 'System.String') LIKE '%{tekst}%' OR " +
            $"Convert(KontrahentId, 'System.String') LIKE '%{tekst}%' OR " +
            $"Convert(PracownikId, 'System.String') LIKE '%{tekst}%'";

        fakturyDataGridView.DataSource = fakturyBindingSource;
        }

      fakturyDataGridView.Refresh();
      AktualizujTytul();
      }

    private bool ZapiszZmiany() {
      try {
        this.Validate();

        this.klienciBindingSource.EndEdit();
        this.pracownicyBindingSource.EndEdit();
        this.kontrahenciBindingSource.EndEdit();
        this.fakturyBindingSource.EndEdit();

        if(!WalidujDane())
          return false;

        this.klienciTableAdapter.Update(this.firmaDataSet.Klienci);
        this.pracownicyTableAdapter.Update(this.firmaDataSet.Pracownicy);
        this.kontrahenciTableAdapter.Update(this.firmaDataSet1.Kontrahenci);
        this.fakturySprzedazyTableAdapter.Update(this.firmaDataSet.FakturySprzedazy);

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
        if(row.RowState == DataRowState.Deleted)
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
        if(row.RowState == DataRowState.Deleted)
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

    private void btnWszystkieFaktury_Click(object sender,EventArgs e) {
      fakturyDataGridView.DataSource = fakturyBindingSource;
      UstawAktywnaSekcje(labelFaktury);
      }

    private void btnNiezaplacone_Click(object sender,EventArgs e) {
      var tabela = firmaDataSet.FakturySprzedazy;
      var widok = new DataView(tabela);

      widok.RowFilter = "Zaplacono < Netto + Vat";
      fakturyDataGridView.DataSource = widok;
      UstawAktywnaSekcje(labelFaktury);
      
      fakturyDataGridView.Refresh();
      }

    private void btnFakturyDostawcy_Click(object sender,EventArgs e) {
      if(kontrahenciBindingSource.Current == null) {
        MessageBox.Show(
            "Najpierw wybierz dostawcę.",
            "Informacja",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
        return;
        }

      DataRowView rowView = kontrahenciBindingSource.Current as DataRowView;
      if(rowView == null)
        return;

      int kontrahentId = Convert.ToInt32(rowView["Id"]);

      var tabela = firmaDataSet.FakturySprzedazy;
      var widok = new DataView(tabela);

      widok.RowFilter = $"KontrahentId = {kontrahentId}";
      fakturyDataGridView.DataSource = widok;
      UstawAktywnaSekcje(labelFaktury);
      }

    private void StylizujGrid(DataGridView dgv) {
      dgv.BorderStyle = BorderStyle.None;
      dgv.BackgroundColor = Color.White;
      dgv.EnableHeadersVisualStyles = false;

      dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230,236,242);
      dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(33,37,41);
      dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI",9F,FontStyle.Bold);
      dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

      dgv.DefaultCellStyle.BackColor = Color.White;
      dgv.DefaultCellStyle.ForeColor = Color.FromArgb(33,37,41);
      dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0,120,215);
      dgv.DefaultCellStyle.SelectionForeColor = Color.White;
      dgv.DefaultCellStyle.Font = new Font("Segoe UI",9F,FontStyle.Regular);

      dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248,250,252);

      dgv.GridColor = Color.FromArgb(220,224,230);
      dgv.RowHeadersVisible = false;
      dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dgv.MultiSelect = false;
      dgv.AllowUserToResizeRows = false;
      dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      }

    private void StylizujPrzycisk(Button btn) {
      btn.FlatStyle = FlatStyle.Flat;
      btn.FlatAppearance.BorderSize = 1;
      btn.FlatAppearance.BorderColor = Color.FromArgb(200,205,210);
      btn.BackColor = Color.White;
      btn.ForeColor = Color.FromArgb(33,37,41);
      btn.Font = new Font("Segoe UI",9F,FontStyle.Regular);
      btn.Cursor = Cursors.Hand;
      btn.TextAlign = ContentAlignment.MiddleCenter;
      }

    private void StylizujGlownyPrzycisk(Button btn) {
      btn.FlatStyle = FlatStyle.Flat;
      btn.FlatAppearance.BorderSize = 1;
      btn.FlatAppearance.BorderColor = Color.FromArgb(0,120,215);
      btn.BackColor = Color.FromArgb(0,120,215);
      btn.ForeColor = Color.White;
      btn.Font = new Font("Segoe UI",9F,FontStyle.Regular);
      btn.Cursor = Cursors.Hand;
      btn.TextAlign = ContentAlignment.MiddleCenter;
      }

    private void DodajEfektHover(Button btn) {
      btn.MouseEnter += (s,e) => {
        btn.BackColor = Color.FromArgb(230,240,250);
        btn.FlatAppearance.BorderColor = Color.FromArgb(0,120,215);
      };

      btn.MouseLeave += (s,e) => {
        btn.BackColor = Color.White;
        btn.FlatAppearance.BorderColor = Color.FromArgb(200,205,210);
      };
      }
    private void DodajEfektHoverGlowny(Button btn) {
      btn.MouseEnter += (s,e) => {
        btn.BackColor = Color.FromArgb(28,151,234);
      };

      btn.MouseLeave += (s,e) => {
        btn.BackColor = Color.FromArgb(0,120,215);
      };
      }
    private void DodajEfektFocus(TextBox txt) {
      txt.BorderStyle = BorderStyle.FixedSingle;
      txt.BackColor = Color.White;
      txt.Font = new Font("Segoe UI",9F,FontStyle.Regular);

      txt.Enter += (s,e) => {
        txt.BackColor = Color.FromArgb(255,255,240);
      };

      txt.Leave += (s,e) => {
        txt.BackColor = Color.White;
      };
      }

    private void StylizujLabelSekcji(Label lbl) {
      lbl.ForeColor = Color.FromArgb(33,37,41);
      lbl.BackColor = Color.Transparent;
      lbl.Font = new Font("Segoe UI",10F,FontStyle.Bold);
      }

    private void UstawAktywnaSekcje(Label aktywna) {
      Color normalny = Color.FromArgb(33,37,41);
      Color aktywny = Color.FromArgb(0,120,215);

      labelKlienci.ForeColor = normalny;
      labelPracownicy.ForeColor = normalny;
      labelKontrahenci.ForeColor = normalny;
      labelFaktury.ForeColor = normalny;

      aktywna.ForeColor = aktywny;
      }
    private void fakturyDataGridView_CellFormatting(object sender,DataGridViewCellFormattingEventArgs e) {
      var dgv = sender as DataGridView;

      if(dgv.Rows[e.RowIndex].DataBoundItem == null)
        return;

      try {
        DataRowView rowView = dgv.Rows[e.RowIndex].DataBoundItem as DataRowView;
        if(rowView == null)
          return;

        decimal netto = Convert.ToDecimal(rowView["Netto"]);
        decimal vat = Convert.ToDecimal(rowView["Vat"]);
        decimal zaplacono = Convert.ToDecimal(rowView["Zaplacono"]);

        decimal suma = netto + vat;

        if(zaplacono < suma) {
          dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255,235,235);
          dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(255,180,180);
          }
        else {
          dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(235,255,235);
          dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(180,230,180);
          }
        } catch {
        // 
        }
      }

    }
  }
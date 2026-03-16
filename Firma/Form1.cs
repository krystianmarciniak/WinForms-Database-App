using System;
using System.Windows.Forms;

namespace Firma {
  public partial class Form1:Form {
    public Form1() {
      InitializeComponent();
      this.Load += Form1_Load;
      this.FormClosing += Form1_FormClosing;
      klienciBindingSource.ListChanged += KlienciBindingSource_ListChanged;
      }
    private void Form1_Load(object sender,EventArgs e) {
      this.klienciTableAdapter.Fill(this.firmaDataSet.Klienci);

      if(klienciDataGridView.Columns.Contains("IdKlienta")) {
        klienciDataGridView.Columns["IdKlienta"].Visible = false;
        }
      AktualizujTytul();
      }
    private void Form1_FormClosing(object sender,FormClosingEventArgs e) {
      this.Validate();
      this.klienciBindingSource.EndEdit();
      this.klienciTableAdapter.Update(this.firmaDataSet.Klienci);
      }

    private void btnUsun_Click(object sender,EventArgs e) {
      if(klienciBindingSource.Current != null) {
        DialogResult wynik = MessageBox.Show(
            "Czy na pewno chcesz usunąć klienta?",
            "Potwierdzenie",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if(wynik == DialogResult.Yes) {
          klienciBindingSource.RemoveCurrent();
          }
        }
      }
    private void btnSzukaj_Click(object sender,EventArgs e) {
      string nazwisko = txtSzukaj.Text.Trim();

      if(nazwisko != "") {
        klienciBindingSource.Filter = $"Nazwisko LIKE '%{nazwisko}%'";
        }
      }
    private void btnReset_Click(object sender,EventArgs e) {
      klienciBindingSource.RemoveFilter();
      }
    private void AktualizujTytul() {
      int liczba = klienciBindingSource.Count;
      this.Text = "Firma – liczba klientów: " + liczba;
      }
    private void KlienciBindingSource_ListChanged(object sender,System.ComponentModel.ListChangedEventArgs e) {
      AktualizujTytul();
      }
    private void txtSzukaj_TextChanged(object sender,EventArgs e) {
      string tekst = txtSzukaj.Text.Trim();

      if(tekst == "")
        klienciBindingSource.RemoveFilter();
      else
        klienciBindingSource.Filter = $"Nazwisko LIKE '%{tekst}%'";
      }


    }
  }
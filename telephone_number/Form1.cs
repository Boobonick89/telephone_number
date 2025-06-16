using System.Text.Json;

namespace telephone_number
{
    public partial class Form1 : Form
    {
        private List<Telephone> _telephones = new List<Telephone>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ButAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTelephoneNumber.Text, out int telNumber) ||
               !int.TryParse(txtBoxNumber.Text, out int bNumber) ||
                !int.TryParse(txtPairNumber.Text, out int pNumber))
            {
                MessageBox.Show("Введите корректные числовые значения", "Ошибка ввода", MessageBoxButtons.OK);
                return;
            }

            var telephone = new Telephone
            {
                Shop = txtShop.Text,
                Subdivision = txtSubdivision.Text,
                WhoOwns = txtWhoOwns.Text,
                TelephoneNumber = telNumber,
                BoxNumber = bNumber,
                PairNumber = pNumber
            };

            _telephones.Add(telephone);
            RefreshList();
            ClearInputs();

        }

        private void RefreshList()
        {
            telephoneList.DataSource = null;
            telephoneList.DataSource = _telephones;
        }

        private void ButnRemove_Click(object sender, EventArgs e)
        {
            if (telephoneList.SelectedItem is Telephone selectedTelephone)
            {
                _telephones.Remove(selectedTelephone);
                RefreshList();
            }
        }

        private void ButnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();

            var result = _telephones.Where(t => t.WhoOwns.ToLower().Contains(search) ||
                                            t.TelephoneNumber.ToString().Contains(search)).ToList();

            telephoneList.DataSource = null;
            telephoneList.DataSource = result;

            txtSearch.Text = "";

        }

        private void ClearInputs()
        {
            txtShop.Clear();
            txtSubdivision.Clear();
            txtWhoOwns.Clear();
            txtTelephoneNumber.Clear();
            txtBoxNumber.Clear();
            txtPairNumber.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string json = JsonSerializer.Serialize(_telephones, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("telephones.json", json);
                MessageBox.Show("Номера сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении", ex.Message);
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if(File.Exists("telephones.json"))
                {
                    string json = File.ReadAllText("telephones.json");
                    _telephones = JsonSerializer.Deserialize<List<Telephone>>(json) ?? new List<Telephone>();
                    RefreshList();
                    MessageBox.Show("Номера загружены");
                }
                else
                {
                    MessageBox.Show("Файл не найден");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке", ex.Message);
            }
        }
    }
    class Telephone
    {
        public string Shop { get; set; }
        public string Subdivision { get; set; }
        public string WhoOwns { get; set; }
        public int TelephoneNumber { get; set; }
        public int BoxNumber { get; set; }
        public int PairNumber { get; set; }

        public Telephone() { }

        public Telephone(string shop, string subdivision, string whoOwns, int telephoneNumber, int boxNumber, int pairNumber)
        {
            Shop = shop;
            Subdivision = subdivision;
            WhoOwns = whoOwns;
            TelephoneNumber = telephoneNumber;
            BoxNumber = boxNumber;
            PairNumber = pairNumber;

        }

        public override string ToString()
        {
            return $"{TelephoneNumber} - {Shop} {Subdivision} {WhoOwns} номер бокса {BoxNumber} номер пары {PairNumber}";
        }

    }

}

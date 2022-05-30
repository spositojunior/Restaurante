using Google.Apis.PeopleService.v1.Data;

namespace Restaurante
{
    public partial class F_Edit : Form
    {
        TextBoxBase[] txb = new TextBoxBase[6];
        F_Principal UFA = new();
        public F_Edit(F_Principal OF)
        {
            InitializeComponent();
            #region Declarate Variables
            txb[0] = tb_1;
            txb[1] = mb_2;
            txb[2] = tb_3;
            txb[3] = tb_4;
            txb[4] = tb_5;
            txb[5] = tb_6;
            UFA = OF;
            #endregion

            // no caso aqui... ele precisa puxar exatamente oq era no numero da database...
            // tbm é preciso retirar esses 2 botoes de DDD
            string cut55 = OF.tabela.Rows[OF.selectedindex]["Tel"].ToString();
            cut55 = cut55.Remove(0, cut55.Length - 12);//n é exatamente 12... é variavel pelo fato de ter numero de cel com 9 digitos e fixo..
            //e com ou sem ddd
            
            txb[0].Text = OF.cb_1.Text;
            txb[1].Text = cut55;
            txb[2].Text = OF.tb_3.Text;
            txb[3].Text = OF.tb_4.Text;
            txb[4].Text = OF.tb_5.Text;
            txb[5].Text = OF.tb_6.Text;

            tb_1.PlaceholderText = OF.cb_1.Text;
            tb_3.PlaceholderText = OF.tb_3.Text != null ? OF.tb_3.Text : tb_3.PlaceholderText;
            tb_4.PlaceholderText = OF.tb_4.Text != null ? OF.tb_4.Text : tb_4.PlaceholderText;
            tb_5.PlaceholderText = OF.tb_5.Text != null ? OF.tb_5.Text : tb_5.PlaceholderText;
            tb_6.PlaceholderText = OF.tb_6.Text != null ? OF.tb_6.Text : tb_6.PlaceholderText;
        }
        private void btn_add_Click(object sender, EventArgs e)//Add Contact Button
        {
            if (txb[0].Text.Length > 0 && txb[1].Text.Length == 15)
            {
                Cursor.Current = Cursors.WaitCursor;
                btn_add.Enabled = false;
                try
                {
                    EditClient();
                }
                catch (AggregateException ex)
                {
                    foreach (var ie in ex.InnerExceptions)
                    {
                        MessageBox.Show("ERROR: " + ie.Message);
                    }
                }
                Cursor.Current = DefaultCursor;
                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha os Dados");
            }
        }
        private void EditClient()//Create new contact to GoogleContacs and add to datatable // INCOMPLETE
        {
            //set data strings to person
            string phone = txb[1].Text.Replace("(", "");
            phone = phone.Replace(")", "");
            phone = phone.Replace(" ","");
            phone = "+55"+phone;
            string adress = txb[2].Text + " - " + txb[3].Text;

            //get resource people by datatable "Pessoa"
            string resourcePeople = UFA.tabela.Rows[UFA.selectedindex]["Pessoa"].ToString();

            //edit person with news data
            Person person = new()
            {
                Names = new List<Name>() { new Name() { GivenName = txb[0].Text } },
                PhoneNumbers = new List<PhoneNumber>() { new PhoneNumber() { Value = phone } },
                Addresses = new List<Address>() { new Address() { StreetAddress = adress, ExtendedAddress = txb[4].Text } },
                Biographies = new List<Biography>() { new Biography() { Value = txb[5].Text } },
                ETag = UFA.tabela.Rows[UFA.selectedindex]["Etag"].ToString()
            };

            var request = UFA.service.People.UpdateContact(person,resourcePeople);
            request.UpdatePersonFields = "names,phoneNumbers,Addresses,Biographies";

            request.Execute();
            //continues to datatable
            UFA.tabela.Rows.RemoveAt(UFA.selectedindex);
            UFA.AddEditClient(resourcePeople,person.ETag,txb[0].Text,phone,txb[2].Text,txb[3].Text,txb[4].Text,txb[5].Text);
        }
        private void btn_clear_Click(object sender, EventArgs e)//Clear button
        {
            for(int x=0;x<6;x++)
            {
                txb[x].Text = "";
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)//Exit button
        {
            this.Close();
        }
    }
}

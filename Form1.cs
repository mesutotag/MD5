using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MD5_SIFRELEME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnsifrele_Click(object sender, EventArgs e)
        {
            // şifrelenen texti textBox2.Text ne yazdırdık
            textBox3.Text = Md5Sifreleme.md5(textBox2.Text);
            
        }

        SqlConnection baglantı = new SqlConnection("Server=DESKTOP-CVTIGR0\\SQLEXPRESS; Database=MD; Integrated Security=true;");

        

        private void btnkayıt_Click(object sender, EventArgs e)
        {
                        
            baglantı.Open();
                        
            SqlCommand komut = new SqlCommand("insert into Login(UserName,Password)values(@UserName,@Password)", baglantı);
            
            komut.Parameters.AddWithValue("@UserName", textBox1.Text);
            komut.Parameters.AddWithValue("@Password", Md5Sifreleme.md5(textBox2.Text));
            
            komut.ExecuteNonQuery();
            
            baglantı.Close();

        }
    }
}

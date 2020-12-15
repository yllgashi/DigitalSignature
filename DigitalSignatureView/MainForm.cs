using System.Windows.Forms;
using DigitalSignature.DataAccess;
using DigitalSignature.Models;
using DigitalSignature.Services;

namespace DigitalSignatureView {
    public partial class MainForm : Form {
        private User user;
        public MainForm(User user) {
            this.user = user;
            InitializeComponent();

            listBoxUser.Items.Add(UserServices.AllUserServices());

        }
        
        
        
    }
}
using SnackMindAPI.ApiClient;
using SnackMindAPI.Models;

using SnackMindModel.Place.Firm;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SnackMindUI.MainForms
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        SmApiClient smApiClient = new SmApiClient();
        public frmMain()
        {
            InitializeComponent();
            Load += frmMain_Load;
            //simpleButton1.Click += SimpleButton1_Click;
        }

        private async Task SimpleButton1_Click(object sender, EventArgs e)
        {
            await Get();
        }

        private async Task Get()
        {
            //var result = await smApiClient.Get<ApiResponse<List<mdlFirm>>>("api/firms");

            var result = await smApiClient.Get<ApiResponse<mdlFirm>>("");


            gridLookUpEdit1.Properties.DataSource = result.Data;
        }
        private async void frmMain_Load(object sender, EventArgs e)
        {
            await Get();
        }
    }
}
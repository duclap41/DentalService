using DentalService.Info;
using SqlKata;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalService.Service
{
    public partial class ServiceList : UserControl
    {
        static ServiceList instance;
        public static ServiceList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ServiceList();
                }
                if (!instance.Visible)
                {
                    instance.Visible = true;
                }
                return instance;
            }
        }

        public ServiceList()
        {
            InitializeComponent();
            instance = this;
            this.Dock = DockStyle.Fill;

            LoadServices();
        }

        // 
        private void LoadServices()
        {
            var services = DataAccess.LoadTable.services;

            foreach (var service in services)
            {
                ServiceName serviceName = new ServiceName();
                serviceName.LoadData(service.ServiceName);
                fLPnDropList.Controls.Add(serviceName);
            }
        }

        private void ServiceList_MouseLeave(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                this.Visible = false;
            }
        }
    }
}

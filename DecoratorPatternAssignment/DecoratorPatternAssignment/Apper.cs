using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorPatternAssignment
{
    public enum PatternsEnum
    {
        DECORATOR,
        STRATEGY,
        ADAPTER,
        ABSTRACT_FACTORY,
    }

    public partial class Apper : Form
    {
        private BaseApp baseApp;
        private List<IApp> appDecorations;

        private IApp getLastVersion() { return this.appDecorations[this.appDecorations.Count - 1]; }

        private void UpdateGUI()
        {
            this.tbGeneratedDesctiption.Text = this.getLastVersion().ToString();
            this.tbComplexityScore.Text = this.getLastVersion().ToString();
        }

        public Apper()
        {
            InitializeComponent();
            this.baseApp = new BaseApp();
            this.appDecorations = new List<IApp>();
            this.appDecorations.Add(baseApp);

            this.rbWeb.Checked = true;
            this.baseApp.SetTechnology(new WebTechnology());

            this.cmbPatternsToAdd.Items.Add(PatternsEnum.DECORATOR.ToString());
            this.cmbPatternsToAdd.Items.Add(PatternsEnum.STRATEGY.ToString());
            this.cmbPatternsToAdd.Items.Add(PatternsEnum.ADAPTER.ToString());
            this.cmbPatternsToAdd.Items.Add(PatternsEnum.ABSTRACT_FACTORY.ToString());

            this.UpdateGUI();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DesignPatternDecorator appWithDecorator;
            switch (this.cmbPatternsToAdd.SelectedIndex)
            {
                case (int)PatternsEnum.DECORATOR:
                    appWithDecorator = new Decorator(this.getLastVersion());
                    this.appDecorations.Add(appWithDecorator);
                    break;
                case (int)PatternsEnum.ADAPTER:
                    appWithDecorator = new Adapter(this.getLastVersion());
                    this.appDecorations.Add(appWithDecorator);
                    break;
                case (int)PatternsEnum.ABSTRACT_FACTORY:
                    appWithDecorator = new AbstractFactory(this.getLastVersion());
                    this.appDecorations.Add(appWithDecorator);
                    break;
                case (int)PatternsEnum.STRATEGY:
                    appWithDecorator = new Strategy(this.getLastVersion());
                    this.appDecorations.Add(appWithDecorator);
                    break;
            }
            this.UpdateGUI();
        }

        private void DetermineAppTechnology()
        {
            if (this.rbDesktop.Checked)
            {
                this.baseApp.SetTechnology(new DesktopTechnology());
            }
            if (this.rbWeb.Checked)
            {
                this.baseApp.SetTechnology(new WebTechnology());
            }
            this.UpdateGUI();
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            this.DetermineAppTechnology();
        }

        private void tbAppName_TextChanged(object sender, EventArgs e)
        {
            this.baseApp.Name = this.tbAppName.Text;
            this.UpdateGUI();
        }

        private void btnDeploy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.getLastVersion().ToString(), "Congrats, your app is deployed!");
        }
    }
}

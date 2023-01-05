using RPrybluda.EEXI.Domain;

namespace EEXI.WinForm

{
    public partial class Form01 : Form
    {
        public Form01()
        {
            InitializeComponent();
        }





        private void Form01_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label03_Click(object sender, EventArgs e)
        {

        }

        private void bCalc_Click(object sender, EventArgs e)
        {
            string shipType = Convert.ToString(comboBox1.Text);
            double deadweight = Convert.ToDouble(tB01_Deadweight.Text);
            double grossTonnage = Convert.ToDouble(tB02_GrossTonnage.Text);

            double reductFactor = ReductionFactor.CalcReductFactor(shipType, deadweight, grossTonnage);
            double refLineValueEEDI = RefLineValueEEDI.CalcRefLineValueEEDI(shipType, deadweight, grossTonnage);
            double reqEEXI = RequiredEEXI.CalcReqEEXI(refLineValueEEDI, reductFactor);

            tB03_ResEEDIRefLine.Text = Convert.ToString(Math.Round(refLineValueEEDI, 2, MidpointRounding.AwayFromZero));
            tB04_ResRequiredEEXI.Text = Convert.ToString(Math.Round(reqEEXI, 2, MidpointRounding.AwayFromZero));

        }

        private void bClear_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            tB01_Deadweight.Text = "";
            tB02_GrossTonnage.Text = "";
            tB03_ResEEDIRefLine.Text = "";
            tB04_ResRequiredEEXI.Text = "";
        }

        private void tB03_ResEEDIRefLine_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
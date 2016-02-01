using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anvifox
{
    public partial class Tyccoon : Form
    {

        #region Variables
        #region Money Variables
        int money = 800;
        int debt = 0;
        int income = 0;
        string selected_building = "None";
        #endregion
        #region Item Variables
        int owned_factories = 0;
        int owned_powerplants = 0;
        #endregion
        #region Resources
        int nuclear_waste = 0;
        int uranium_ore = 0;
        int coal = 0;
        int iron_ore = 0;
        int iron_refined = 0;
        int steel = 0;
        int carbon = 0;
        int silicon = 0;
        int gold_ore = 0;
        int alumium = 0;
        int gold_refined = 0;
        int copper_ore = 0;
        int copper_refined = 0;
        int uranium_refined = 0;
        int rock = 0;
        #endregion
        #region Service Resources
        int power = 0;
        int power_intake = 0;
        int XP = 0;
        int XP_intake = 0;
        int level = 0;
        int anvios = 0;
        #endregion


        #endregion

        public Tyccoon()
        {
            InitializeComponent();

            build_animalfoodyard.Hide();
            build_assembly.Hide();
            build_bio.Hide();
            build_chem.Hide();
            build_destilation.Hide();
            build_farm.Hide();
            build_foods.Hide();
            build_heat.Hide();
            build_logi.Hide();
            build_nexus.Hide();
            build_nuclear.Hide();
            build_office.Hide();
            build_oil.Hide();
            build_silo.Hide();
            build_storage.Hide();
        }

        private void menu_build_Click(object sender, EventArgs e)
        {
            build_animalfoodyard.Show();
            build_assembly.Show();
            build_bio.Show();
            build_chem.Show();
            build_destilation.Show();
            build_farm.Show();
            build_foods.Show();
            build_heat.Show();
            build_logi.Show();
            build_nexus.Show();
            build_nuclear.Show();
            build_office.Show();
            build_oil.Show();
            build_silo.Show();
            build_storage.Show();

            info_factories.Hide();
            info_money.Hide();
            info_power.Hide();
            lbl_factories.Hide();
            lbl_money.Hide();
            lbl_power.Hide();
        }

        private void menu_logi_Click(object sender, EventArgs e)
        {
            build_animalfoodyard.Hide();
            build_assembly.Hide();
            build_bio.Hide();
            build_chem.Hide();
            build_destilation.Hide();
            build_farm.Hide();
            build_foods.Hide();
            build_heat.Hide();
            build_logi.Hide();
            build_nexus.Hide();
            build_nuclear.Hide();
            build_office.Hide();
            build_oil.Hide();
            build_silo.Hide();
            build_storage.Hide();

            info_factories.Show();
            info_money.Show();
            info_power.Show();
            lbl_factories.Show();
            lbl_money.Show();
            lbl_power.Show();
        }

        private void build_nuclear_Click(object sender, EventArgs e)
        {
            if(money == 800 || money < 800)
            {
                money = money - 800;
                power_intake = power_intake + 2;
                owned_powerplants = owned_powerplants + 1;
                lbl_factories.Text = owned_factories.ToString();

            }
        }

        private void Tick_Timer_Tick(object sender, EventArgs e)
        {
            power_intake = power + power_intake;
            lbl_money.Text = money + "$";
        }
    }
}

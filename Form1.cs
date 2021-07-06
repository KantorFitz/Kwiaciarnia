using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kwiaciarnia
{
    public partial class Form1 : Form
    {
        private Repository _repository;

        public Form1()
        {
            InitializeComponent();

            _repository = new Repository();

            InitList();
        }

        private void InitList()
        {
            var places = _repository.GetPlaces();
            cbPlace.Items.AddRange(places.ToArray());

            var requirements = _repository.GetRequirements();
            cbRequirement.Items.AddRange(requirements.ToArray());

            var sorts = _repository.GetSorts();
            cbSort.Items.AddRange(sorts.ToArray());

            var species = _repository.GetSpecies();
            cbSpecie.Items.AddRange(species.ToArray());

            var traits = _repository.GetTraits();
            cbTrait.Items.AddRange(traits.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _repository.AddFlower(new Flowers()
            {
                Name = txtFlowerName.Text,
                PlaceId = ((Places)cbPlace.SelectedItem).PlaceId,
                RequirementId = ((Requirements)cbRequirement.SelectedItem).RequirementId,
                SortId = ((Sorts)cbSort.SelectedItem).SortId,
                SpecieId = ((Species)cbSpecie.SelectedItem).SpeciesId,
                TraitId = ((Traits)cbTrait.SelectedItem).TraitId
            });
        }
    }
}

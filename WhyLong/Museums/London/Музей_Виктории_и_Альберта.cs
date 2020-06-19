using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhyLong.Museums.London
{
    public partial class Музей_Виктории_и_Альберта : Form
    {
        public Музей_Виктории_и_Альберта()
        {
            InitializeComponent();
        }

        private void Музей_Виктории_и_Альберта_Load(object sender, EventArgs e)
        {
            mapVictoriaAndAlbertMuseum.DragButton = MouseButtons.Left;
            mapVictoriaAndAlbertMuseum.MapProvider = GMapProviders.GoogleMap;
            mapVictoriaAndAlbertMuseum.ShowCenter = false;

            mapVictoriaAndAlbertMuseum.Position = new PointLatLng(51.496727, -0.172026);
            mapVictoriaAndAlbertMuseum.MinZoom = 1;
            mapVictoriaAndAlbertMuseum.MaxZoom = 100;
            mapVictoriaAndAlbertMuseum.Zoom = 13.5;

            PointLatLng pointVictoriaAndAlbertMuseum = new PointLatLng(51.496727, -0.172026);
            GMapMarker markerVictoriaAndAlbertMuseum = new GMarkerGoogle(pointVictoriaAndAlbertMuseum, GMarkerGoogleType.red_dot);
            GMapOverlay markersVictoriaAndAlbertMuseum = new GMapOverlay("markersVictoriaAndAlbertMuseum");
            markersVictoriaAndAlbertMuseum.Markers.Add(markerVictoriaAndAlbertMuseum);
            mapVictoriaAndAlbertMuseum.Overlays.Add(markersVictoriaAndAlbertMuseum);
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Museums.London.Lodon f = new Museums.London.Lodon();
            f.ShowDialog();
        }
    }
}

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

namespace WhyLong.Museums.Moscow
{
    public partial class Музей_хоккея : Form
    {
        public Музей_хоккея()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Museums.Moscow.Moscow f = new Museums.Moscow.Moscow();
            f.ShowDialog();
        }

        private void Музей_хоккея_Load(object sender, EventArgs e)
        {
            mapHockeyMuseum.DragButton = MouseButtons.Left;
            mapHockeyMuseum.MapProvider = GMapProviders.GoogleMap;
            mapHockeyMuseum.ShowCenter = false;

            mapHockeyMuseum.Position = new PointLatLng(55.704824, 37.635700);
            mapHockeyMuseum.MinZoom = 1;
            mapHockeyMuseum.MaxZoom = 100;
            mapHockeyMuseum.Zoom = 13.5;

            PointLatLng pointHockeyMuseum = new PointLatLng(55.704824, 37.635700);
            GMapMarker markerHockeyMuseum = new GMarkerGoogle(pointHockeyMuseum, GMarkerGoogleType.red_dot);
            GMapOverlay markersHockeyMuseum = new GMapOverlay("markersHockeyMuseum");
            markersHockeyMuseum.Markers.Add(markerHockeyMuseum);
            mapHockeyMuseum.Overlays.Add(markersHockeyMuseum);
        }
    }
}

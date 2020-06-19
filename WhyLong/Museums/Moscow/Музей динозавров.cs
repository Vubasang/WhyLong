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
    public partial class Музей_динозавров : Form
    {
        public Музей_динозавров()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Museums.Moscow.Moscow f = new Museums.Moscow.Moscow();
            f.ShowDialog();
        }

        private void Музей_динозавров_Load(object sender, EventArgs e)
        {
            mapDinosaurMuseum.DragButton = MouseButtons.Left;
            mapDinosaurMuseum.MapProvider = GMapProviders.GoogleMap;
            mapDinosaurMuseum.ShowCenter = false;

            mapDinosaurMuseum.Position = new PointLatLng(55.624344, 37.514453);
            mapDinosaurMuseum.MinZoom = 1;
            mapDinosaurMuseum.MaxZoom = 100;
            mapDinosaurMuseum.Zoom = 13.5;

            PointLatLng pointDinosaurMuseum = new PointLatLng(55.624344, 37.514453);
            GMapMarker markerDinosaurMuseum = new GMarkerGoogle(pointDinosaurMuseum, GMarkerGoogleType.red_dot);
            GMapOverlay markersDinosaurMuseum = new GMapOverlay("markersDinosaurMuseum");
            markersDinosaurMuseum.Markers.Add(markerDinosaurMuseum);
            mapDinosaurMuseum.Overlays.Add(markersDinosaurMuseum);
        }
    }
}

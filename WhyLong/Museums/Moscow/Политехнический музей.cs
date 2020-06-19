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
    public partial class Политехнический_музей : Form
    {
        public Политехнический_музей()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Museums.Moscow.Moscow f = new Museums.Moscow.Moscow();
            f.ShowDialog();
        }

        private void Политехнический_музей_Load(object sender, EventArgs e)
        {
            mapPolytechnicalMuseum.DragButton = MouseButtons.Left;
            mapPolytechnicalMuseum.MapProvider = GMapProviders.GoogleMap;
            mapPolytechnicalMuseum.ShowCenter = false;

            mapPolytechnicalMuseum.Position = new PointLatLng(55.758045, 37.628786);
            mapPolytechnicalMuseum.MinZoom = 1;
            mapPolytechnicalMuseum.MaxZoom = 100;
            mapPolytechnicalMuseum.Zoom = 13.5;

            PointLatLng pointPolytechnicalMuseum = new PointLatLng(55.758045, 37.628786);
            GMapMarker markerPolytechnicalMuseum = new GMarkerGoogle(pointPolytechnicalMuseum, GMarkerGoogleType.red_dot);
            GMapOverlay markersPolytechnicalMuseum = new GMapOverlay("markersPolytechnicalMuseum");
            markersPolytechnicalMuseum.Markers.Add(markerPolytechnicalMuseum);
            mapPolytechnicalMuseum.Overlays.Add(markersPolytechnicalMuseum);
        }
    }
}

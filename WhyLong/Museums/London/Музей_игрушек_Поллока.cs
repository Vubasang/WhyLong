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
    public partial class Музей_игрушек_Поллока : Form
    {
        public Музей_игрушек_Поллока()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Museums.London.Lodon f = new Museums.London.Lodon();
            f.ShowDialog();
        }

        private void Музей_игрушек_Поллока_Load(object sender, EventArgs e)
        {
            mapPollockToyMuseum.DragButton = MouseButtons.Left;
            mapPollockToyMuseum.MapProvider = GMapProviders.GoogleMap;
            mapPollockToyMuseum.ShowCenter = false;

            mapPollockToyMuseum.Position = new PointLatLng(51.520308, -0.135243);
            mapPollockToyMuseum.MinZoom = 1;
            mapPollockToyMuseum.MaxZoom = 100;
            mapPollockToyMuseum.Zoom = 13.5;

            PointLatLng pointPollockToyMuseum = new PointLatLng(51.520308, -0.135243);
            GMapMarker markerPollockToyMuseum = new GMarkerGoogle(pointPollockToyMuseum, GMarkerGoogleType.red_dot);
            GMapOverlay markersPollockToyMuseum = new GMapOverlay("markersPollockToyMuseum");
            markersPollockToyMuseum.Markers.Add(markerPollockToyMuseum);
            mapPollockToyMuseum.Overlays.Add(markersPollockToyMuseum);
        }
    }
}

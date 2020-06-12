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
    public partial class Национальный_морской_музей : Form
    {
        public Национальный_морской_музей()
        {
            InitializeComponent();
        }

        private void Национальный_морской_музей_Load(object sender, EventArgs e)
        {
            mapNationalMaritimeMuseum.DragButton = MouseButtons.Left;
            mapNationalMaritimeMuseum.MapProvider = GMapProviders.GoogleMap;
            mapNationalMaritimeMuseum.ShowCenter = false;

            mapNationalMaritimeMuseum.Position = new PointLatLng(51.481329, -0.005289);
            mapNationalMaritimeMuseum.MinZoom = 1;
            mapNationalMaritimeMuseum.MaxZoom = 100;
            mapNationalMaritimeMuseum.Zoom = 13.5;

            PointLatLng pointNationalMaritimeMuseum = new PointLatLng(51.481329, -0.005289);
            GMapMarker markerNationalMaritimeMuseum = new GMarkerGoogle(pointNationalMaritimeMuseum, GMarkerGoogleType.red_dot);
            GMapOverlay markersNationalMaritimeMuseum = new GMapOverlay("markersNationalMaritimeMuseum");
            markersNationalMaritimeMuseum.Markers.Add(markerNationalMaritimeMuseum);
            mapNationalMaritimeMuseum.Overlays.Add(markersNationalMaritimeMuseum);
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Museums.London.Lodon f = new Museums.London.Lodon();
            f.ShowDialog();
        }
    }
}

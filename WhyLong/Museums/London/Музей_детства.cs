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
    public partial class Музей_детства : Form
    {
        public Музей_детства()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Museums.London.Lodon f = new Museums.London.Lodon();
            f.ShowDialog();
        }

        private void Музей_детства_Load(object sender, EventArgs e)
        {
            mapMuseumOfChildhood.DragButton = MouseButtons.Left;
            mapMuseumOfChildhood.MapProvider = GMapProviders.GoogleMap;
            mapMuseumOfChildhood.ShowCenter = false;

            mapMuseumOfChildhood.Position = new PointLatLng(51.528948, -0.055324);
            mapMuseumOfChildhood.MinZoom = 1;
            mapMuseumOfChildhood.MaxZoom = 100;
            mapMuseumOfChildhood.Zoom = 13.5;

            PointLatLng pointMuseumOfChildhood = new PointLatLng(51.528948, -0.055324);
            GMapMarker markerMuseumOfChildhood = new GMarkerGoogle(pointMuseumOfChildhood, GMarkerGoogleType.red_dot);
            GMapOverlay markersMuseumOfChildhood = new GMapOverlay("markersMuseumOfChildhood");
            markersMuseumOfChildhood.Markers.Add(markerMuseumOfChildhood);
            mapMuseumOfChildhood.Overlays.Add(markersMuseumOfChildhood);
        }
    }
}

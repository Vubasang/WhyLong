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
    public partial class Музей_хлеба : Form
    {
        public Музей_хлеба()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Museums.Moscow.Moscow f = new Museums.Moscow.Moscow();
            f.ShowDialog();
        }

        private void Музей_хлеба_Load(object sender, EventArgs e)
        {
            mapMuseumOfBread.DragButton = MouseButtons.Left;
            mapMuseumOfBread.MapProvider = GMapProviders.GoogleMap;
            mapMuseumOfBread.ShowCenter = false;

            mapMuseumOfBread.Position = new PointLatLng(55.793920, 37.750024);
            mapMuseumOfBread.MinZoom = 1;
            mapMuseumOfBread.MaxZoom = 100;
            mapMuseumOfBread.Zoom = 13.5;

            PointLatLng pointMuseumOfBread = new PointLatLng(55.793920, 37.750024);
            GMapMarker markerMuseumOfBread = new GMarkerGoogle(pointMuseumOfBread, GMarkerGoogleType.red_dot);
            GMapOverlay markersMuseumOfBread = new GMapOverlay("markersMuseumOfBread");
            markersMuseumOfBread.Markers.Add(markerMuseumOfBread);
            mapMuseumOfBread.Overlays.Add(markersMuseumOfBread);
        }
    }
}

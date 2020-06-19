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
    public partial class Литературный_музей : Form
    {
        public Литературный_музей()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Museums.Moscow.Moscow f = new Museums.Moscow.Moscow();
            f.ShowDialog();
        }

        private void Литературный_музей_Load(object sender, EventArgs e)
        {
            mapMuseumOfLiterature.DragButton = MouseButtons.Left;
            mapMuseumOfLiterature.MapProvider = GMapProviders.GoogleMap;
            mapMuseumOfLiterature.ShowCenter = false;

            mapMuseumOfLiterature.Position = new PointLatLng(55.766808, 37.614968);
            mapMuseumOfLiterature.MinZoom = 1;
            mapMuseumOfLiterature.MaxZoom = 100;
            mapMuseumOfLiterature.Zoom = 13.5;

            PointLatLng pointMuseumOfLiterature = new PointLatLng(55.766808, 37.614968);
            GMapMarker markerMuseumOfLiterature = new GMarkerGoogle(pointMuseumOfLiterature, GMarkerGoogleType.red_dot);
            GMapOverlay markersMuseumOfLiterature = new GMapOverlay("markersMuseumOfLiterature");
            markersMuseumOfLiterature.Markers.Add(markerMuseumOfLiterature);
            mapMuseumOfLiterature.Overlays.Add(markersMuseumOfLiterature);
        }
    }
}

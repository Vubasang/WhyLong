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
    public partial class Галерея_Тейт : Form
    {
        public Галерея_Тейт()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Museums.London.Lodon f = new Museums.London.Lodon();
            f.ShowDialog();
        }

        private void Галерея_Тейт_Load(object sender, EventArgs e)
        {
            mapTateGallery.DragButton = MouseButtons.Left;
            mapTateGallery.MapProvider = GMapProviders.GoogleMap;
            mapTateGallery.ShowCenter = false;

            mapTateGallery.Position = new PointLatLng(51.491071, -0.127770);
            mapTateGallery.MinZoom = 1;
            mapTateGallery.MaxZoom = 100;
            mapTateGallery.Zoom = 13.5;

            PointLatLng pointTateGallery = new PointLatLng(51.491071, -0.127770);
            GMapMarker markerTateGallery = new GMarkerGoogle(pointTateGallery, GMarkerGoogleType.red_dot);
            GMapOverlay markersTateGallery = new GMapOverlay("markersTateGallery");
            markersTateGallery.Markers.Add(markerTateGallery);
            mapTateGallery.Overlays.Add(markersTateGallery);
        }
    }
}

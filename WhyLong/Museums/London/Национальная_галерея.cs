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
    public partial class Национальная_галерея : Form
    {
        public Национальная_галерея()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Museums.London.Lodon f = new Museums.London.Lodon();
            f.ShowDialog();
        }

        private void Национальная_галерея_Load(object sender, EventArgs e)
        {
            mapNationalGallery.DragButton = MouseButtons.Left;
            mapNationalGallery.MapProvider = GMapProviders.GoogleMap;
            mapNationalGallery.ShowCenter = false;

            mapNationalGallery.Position = new PointLatLng(51.508974, -0.128276);
            mapNationalGallery.MinZoom = 1;
            mapNationalGallery.MaxZoom = 100;
            mapNationalGallery.Zoom = 13.5;

            PointLatLng pointNationalGallery = new PointLatLng(51.508974, -0.128276);
            GMapMarker markerNationalGallery = new GMarkerGoogle(pointNationalGallery, GMarkerGoogleType.red_dot);
            GMapOverlay markersNationalGallery = new GMapOverlay("markersNationalGallery");
            markersNationalGallery.Markers.Add(markerNationalGallery);
            mapNationalGallery.Overlays.Add(markersNationalGallery);
        }
    }
}

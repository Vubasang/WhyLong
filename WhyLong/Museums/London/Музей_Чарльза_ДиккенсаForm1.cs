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
    public partial class Музей_Чарльза_ДиккенсаForm1 : Form
    {
        public Музей_Чарльза_ДиккенсаForm1()
        {
            InitializeComponent();
        }

        private void Музей_Чарльза_ДиккенсаForm1_Load(object sender, EventArgs e)
        {
            mapCharlesDickensMuseum.DragButton = MouseButtons.Left;
            mapCharlesDickensMuseum.MapProvider = GMapProviders.GoogleMap;
            mapCharlesDickensMuseum.ShowCenter = false;

            mapCharlesDickensMuseum.Position = new PointLatLng(51.523611, -0.116290);
            mapCharlesDickensMuseum.MinZoom = 1;
            mapCharlesDickensMuseum.MaxZoom = 100;
            mapCharlesDickensMuseum.Zoom = 13.5;

            PointLatLng pointCharlesDickensMuseum = new PointLatLng(51.523611, -0.116290);
            GMapMarker markerCharlesDickensMuseum = new GMarkerGoogle(pointCharlesDickensMuseum, GMarkerGoogleType.red_dot);
            GMapOverlay markersCharlesDickensMuseum = new GMapOverlay("markersCharlesDickensMuseum");
            markersCharlesDickensMuseum.Markers.Add(markerCharlesDickensMuseum);
            mapCharlesDickensMuseum.Overlays.Add(markersCharlesDickensMuseum);
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Museums.London.Lodon f = new Museums.London.Lodon();
            f.ShowDialog();
        }
    }
}

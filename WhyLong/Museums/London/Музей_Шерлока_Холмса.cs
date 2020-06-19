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
    public partial class Музей_Шерлока_Холмса : Form
    {
        public Музей_Шерлока_Холмса()
        {
            InitializeComponent();
        }

        private void Музей_Шерлока_Холмса_Load(object sender, EventArgs e)
        {
            mapSherlockHolmesMuseum.DragButton = MouseButtons.Left;
            mapSherlockHolmesMuseum.MapProvider = GMapProviders.GoogleMap;
            mapSherlockHolmesMuseum.ShowCenter = false;

            mapSherlockHolmesMuseum.Position = new PointLatLng(51.523772, -0.158532);
            mapSherlockHolmesMuseum.MinZoom = 1;
            mapSherlockHolmesMuseum.MaxZoom = 100;
            mapSherlockHolmesMuseum.Zoom = 13.5;

            PointLatLng pointSherlockHolmesMuseum = new PointLatLng(51.523772, -0.158532);
            GMapMarker markerSherlockHolmesMuseum = new GMarkerGoogle(pointSherlockHolmesMuseum, GMarkerGoogleType.red_dot);
            GMapOverlay markersSherlockHolmesMuseum = new GMapOverlay("markersSherlockHolmesMuseum");
            markersSherlockHolmesMuseum.Markers.Add(markerSherlockHolmesMuseum);
            mapSherlockHolmesMuseum.Overlays.Add(markersSherlockHolmesMuseum);
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Museums.London.Lodon f = new Museums.London.Lodon();
            f.ShowDialog();
        }
    }
}

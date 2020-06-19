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
    public partial class Архангельский_собор : Form
    {
        public Архангельский_собор()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Museums.Moscow.Moscow f = new Museums.Moscow.Moscow();
            f.ShowDialog();
        }

        private void Архангельский_собор_Load(object sender, EventArgs e)
        {
            mapCathedralOfTheArchangel.DragButton = MouseButtons.Left;
            mapCathedralOfTheArchangel.MapProvider = GMapProviders.GoogleMap;
            mapCathedralOfTheArchangel.ShowCenter = false;

            mapCathedralOfTheArchangel.Position = new PointLatLng(55.750824, 37.616534);
            mapCathedralOfTheArchangel.MinZoom = 1;
            mapCathedralOfTheArchangel.MaxZoom = 100;
            mapCathedralOfTheArchangel.Zoom = 13.5;

            PointLatLng pointCathedralOfTheArchangel = new PointLatLng(55.750824, 37.616534);
            GMapMarker markerCathedralOfTheArchangel = new GMarkerGoogle(pointCathedralOfTheArchangel, GMarkerGoogleType.red_dot);
            GMapOverlay markersCathedralOfTheArchangel = new GMapOverlay("markersCathedralOfTheArchangel");
            markersCathedralOfTheArchangel.Markers.Add(markerCathedralOfTheArchangel);
            mapCathedralOfTheArchangel.Overlays.Add(markersCathedralOfTheArchangel);
        }
    }
}

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
    public partial class Церковь_Ризположения : Form
    {
        public Церковь_Ризположения()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Museums.Moscow.Moscow f = new Museums.Moscow.Moscow();
            f.ShowDialog();
        }

        private void Церковь_Ризположения_Load(object sender, EventArgs e)
        {
            mapChurchOfTheDeposition.DragButton = MouseButtons.Left;
            mapChurchOfTheDeposition.MapProvider = GMapProviders.GoogleMap;
            mapChurchOfTheDeposition.ShowCenter = false;

            mapChurchOfTheDeposition.Position = new PointLatLng(55.750824, 37.616534);
            mapChurchOfTheDeposition.MinZoom = 1;
            mapChurchOfTheDeposition.MaxZoom = 100;
            mapChurchOfTheDeposition.Zoom = 13.5;

            PointLatLng pointChurchOfTheDeposition = new PointLatLng(55.750824, 37.616534);
            GMapMarker markerChurchOfTheDeposition = new GMarkerGoogle(pointChurchOfTheDeposition, GMarkerGoogleType.red_dot);
            GMapOverlay markersChurchOfTheDeposition = new GMapOverlay("markersChurchOfTheDeposition");
            markersChurchOfTheDeposition.Markers.Add(markerChurchOfTheDeposition);
            mapChurchOfTheDeposition.Overlays.Add(markersChurchOfTheDeposition);
        }
    }
}

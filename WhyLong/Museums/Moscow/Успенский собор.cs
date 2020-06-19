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
    public partial class Успенский_собор : Form
    {
        public Успенский_собор()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Museums.Moscow.Moscow f = new Museums.Moscow.Moscow();
            f.ShowDialog();
        }

        private void Успенский_собор_Load(object sender, EventArgs e)
        {
            mapAssumptionCathedral.DragButton = MouseButtons.Left;
            mapAssumptionCathedral.MapProvider = GMapProviders.GoogleMap;
            mapAssumptionCathedral.ShowCenter = false;

            mapAssumptionCathedral.Position = new PointLatLng(55.750982, 37.616984);
            mapAssumptionCathedral.MinZoom = 1;
            mapAssumptionCathedral.MaxZoom = 100;
            mapAssumptionCathedral.Zoom = 13.5;

            PointLatLng pointAssumptionCathedral = new PointLatLng(55.750982, 37.616984);
            GMapMarker markerAssumptionCathedral = new GMarkerGoogle(pointAssumptionCathedral, GMarkerGoogleType.red_dot);
            GMapOverlay markersAssumptionCathedral = new GMapOverlay("markersAssumptionCathedral");
            markersAssumptionCathedral.Markers.Add(markerAssumptionCathedral);
            mapAssumptionCathedral.Overlays.Add(markersAssumptionCathedral);
        }
    }
}

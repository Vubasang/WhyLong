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

namespace WhyLong
{
    public partial class ArtExhibitions_Peterburg : Form
    {
        public ArtExhibitions_Peterburg()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbTime_Exhibition.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
            lbTime_Concert.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
            lbTime_Contest.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
            lbTime_MasterClass.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
            lbTime_Performances.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }
        private void ArtExhibitions_Peterburg_Load(object sender, EventArgs e)
        {
            //Выставки
            mapExhibition.DragButton = MouseButtons.Left;
            mapExhibition.MapProvider = GMapProviders.GoogleMap;
            mapExhibition.ShowCenter = false;

            mapExhibition.Position = new PointLatLng(59.942347, 30.327964);
            mapExhibition.MinZoom = 1;
            mapExhibition.MaxZoom = 100;
            mapExhibition.Zoom = 13.5;

            PointLatLng pointExhibition = new PointLatLng(59.942347, 30.327964);
            GMapMarker markerExhibition = new GMarkerGoogle(pointExhibition, GMarkerGoogleType.red_dot);
            GMapOverlay markersExhibition = new GMapOverlay("markersExhibition");
            markersExhibition.Markers.Add(markerExhibition);
            mapExhibition.Overlays.Add(markersExhibition);

            //Спектакли
            mapPerformances.DragButton = MouseButtons.Left;
            mapPerformances.MapProvider = GMapProviders.GoogleMap;
            mapPerformances.ShowCenter = false;

            mapPerformances.Position = new PointLatLng(59.936763, 30.415714);
            mapPerformances.MinZoom = 1;
            mapPerformances.MaxZoom = 100;
            mapPerformances.Zoom = 13.5;

            PointLatLng pointPerformances = new PointLatLng(59.936763, 30.415714);
            GMapMarker markerPerformances = new GMarkerGoogle(pointPerformances, GMarkerGoogleType.red_dot);
            GMapOverlay markersPerformances = new GMapOverlay("markersPerformances");
            markersPerformances.Markers.Add(markerPerformances);
            mapPerformances.Overlays.Add(markersPerformances);

            //Концерты
            mapConcert.DragButton = MouseButtons.Left;
            mapConcert.MapProvider = GMapProviders.GoogleMap;
            mapConcert.ShowCenter = false;

            mapConcert.Position = new PointLatLng(59.936930, 30.364902);
            mapConcert.MinZoom = 1;
            mapConcert.MaxZoom = 100;
            mapConcert.Zoom = 13.5;

            PointLatLng pointConcert = new PointLatLng(59.936930, 30.364902);
            GMapMarker markerConcert = new GMarkerGoogle(pointConcert, GMarkerGoogleType.red_dot);
            GMapOverlay markersConcert = new GMapOverlay("markersConcert");
            markersConcert.Markers.Add(markerConcert);
            mapConcert.Overlays.Add(markersConcert);

            //Семинары и мастер-классы
            mapMasterClass.DragButton = MouseButtons.Left;
            mapMasterClass.MapProvider = GMapProviders.GoogleMap;
            mapMasterClass.ShowCenter = false;

            mapMasterClass.Position = new PointLatLng(59.935098, 30.281356);
            mapMasterClass.MinZoom = 1;
            mapMasterClass.MaxZoom = 100;
            mapMasterClass.Zoom = 13.5;

            //Конкурсы
            mapContest.DragButton = MouseButtons.Left;
            mapContest.MapProvider = GMapProviders.GoogleMap;
            mapContest.ShowCenter = false;

            mapContest.Position = new PointLatLng(59.935098, 30.281356);
            mapContest.MinZoom = 1;
            mapContest.MaxZoom = 100;
            mapContest.Zoom = 13.5;
        }
    }
}

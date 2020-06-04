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
    public partial class PosterExhibition : Form
    {
        public PosterExhibition()
        {
            InitializeComponent();
        }

        private void BtnExhibitionYakutsk_Click(object sender, EventArgs e)
        {
            ArtExhibitions_Yakutsk f = new ArtExhibitions_Yakutsk();
            f.ShowDialog();
        }

        private void BtnExhibitionMoscow_Click(object sender, EventArgs e)
        {
            ArtExhibitions_Moscow f = new ArtExhibitions_Moscow();
            f.ShowDialog();
        }

        private void BtnExhibitionPeterburg_Click(object sender, EventArgs e)
        {
            ArtExhibitions_Peterburg f = new ArtExhibitions_Peterburg();
            f.ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbTime_PosterExhibition.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

        private void PosterExhibition_Load(object sender, EventArgs e)
        {
            mapPosterExhibition.DragButton = MouseButtons.Left;
            mapPosterExhibition.MapProvider = GMapProviders.GoogleMap;
            mapPosterExhibition.ShowCenter = false;

            mapPosterExhibition.Position = new PointLatLng(62.032229, 129.677061);
            mapPosterExhibition.Position = new PointLatLng(55.760424, 37.547475);
            mapPosterExhibition.Position = new PointLatLng(59.893793, 30.314315);
            mapPosterExhibition.MinZoom = 1;
            mapPosterExhibition.MaxZoom = 100;
            mapPosterExhibition.Zoom = 2;

            PointLatLng pointPosterExhibition_Yakutsk = new PointLatLng(62.032229, 129.677061);
            GMapMarker markerPosterExhibition_Yakutsk = new GMarkerGoogle(pointPosterExhibition_Yakutsk, GMarkerGoogleType.red_dot);
            GMapOverlay markersPosterExhibition_Yakutsk = new GMapOverlay("markersPosterExhibition_Yakutsk");
            markersPosterExhibition_Yakutsk.Markers.Add(markerPosterExhibition_Yakutsk);
            mapPosterExhibition.Overlays.Add(markersPosterExhibition_Yakutsk);

            PointLatLng pointPosterExhibition_Moscow = new PointLatLng(55.760424, 37.547475);
            GMapMarker markerPosterExhibition_Moscow = new GMarkerGoogle(pointPosterExhibition_Moscow, GMarkerGoogleType.red_dot);
            GMapOverlay markersPosterExhibition_Moscow = new GMapOverlay("markersPosterExhibition_Moscow");
            markersPosterExhibition_Moscow.Markers.Add(markerPosterExhibition_Moscow);
            mapPosterExhibition.Overlays.Add(markersPosterExhibition_Moscow);

            PointLatLng pointPosterExhibition_Peterburg = new PointLatLng(59.893793, 30.314315);
            GMapMarker markerPosterExhibition_Peterburg = new GMarkerGoogle(pointPosterExhibition_Peterburg, GMarkerGoogleType.red_dot);
            GMapOverlay markersPosterExhibition_Peterburg = new GMapOverlay("markersPosterExhibition_Peterburg");
            markersPosterExhibition_Peterburg.Markers.Add(markerPosterExhibition_Peterburg);
            mapPosterExhibition.Overlays.Add(markersPosterExhibition_Peterburg);
        }
    }
}

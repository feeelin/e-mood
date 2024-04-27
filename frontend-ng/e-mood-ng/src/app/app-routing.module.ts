import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MoodTrackTableComponent } from './mood-track-table/mood-track-table.component';
import { MoodDashboardComponent } from './mood-dashboard/mood-dashboard.component';
import { MoodPlaylistTableComponent } from './mood-playlist-table/mood-playlist-table.component';

const routes: Routes = [
  { path: '', component: MoodDashboardComponent },
  { path: 'dashboard', component: MoodDashboardComponent },
  { path: 'tracks', component: MoodTrackTableComponent },
  { path: 'playlist', component: MoodPlaylistTableComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

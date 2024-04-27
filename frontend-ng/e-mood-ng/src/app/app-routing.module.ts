import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MoodTrackTableComponent } from './mood-track-table/mood-track-table.component';
import { MoodDashboardComponent } from './mood-dashboard/mood-dashboard.component';

const routes: Routes = [
  { path: '', component: MoodDashboardComponent },
  { path: 'dashboard', component: MoodDashboardComponent },
  { path: 'tracks', component: MoodTrackTableComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

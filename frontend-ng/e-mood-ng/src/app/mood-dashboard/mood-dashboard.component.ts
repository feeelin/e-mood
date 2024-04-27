import { Component, inject } from '@angular/core';
import { Breakpoints, BreakpointObserver } from '@angular/cdk/layout';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-mood-dashboard',
  templateUrl: './mood-dashboard.component.html',
  styleUrl: './mood-dashboard.component.less'
})
export class MoodDashboardComponent {
  private breakpointObserver = inject(BreakpointObserver);

  /** Based on the screen size, switch from standard to one column per row */
  cards = this.breakpointObserver.observe(
    [
      '(min-width: 1600px)',
      Breakpoints.Large,
      Breakpoints.Medium,
      Breakpoints.Small,
      Breakpoints.Handset])
    .pipe(
      map(result => {
        console.log(result);
        const breakpoints = result.breakpoints;

        if (this.breakpointObserver.isMatched('(min-width: 1600px)')) {
          return [
            { title: 'Подписчики', cols: 2, rows: 1 },
            { title: 'Треки', cols: 1, rows: 1 },
            { title: 'Добавить трек', cols: 1, rows: 2 },
          ];
        }
        if (breakpoints[Breakpoints.Large]) {
          return [
            { title: 'Подписчики', cols: 2, rows: 1 },
            { title: 'Треки', cols: 1, rows: 1 },
            { title: 'Добавить трек', cols: 1, rows: 2 },
          ];
        }
        if (breakpoints[Breakpoints.Medium]) {
          return [
            { title: 'Подписчики', cols: 2, rows: 1 },
            { title: 'Треки', cols: 1, rows: 1 },
            { title: 'Добавить трек', cols: 1, rows: 2 },
          ];
        }
        if (breakpoints[Breakpoints.Small]) {
          return [
            { title: 'Подписчики', cols: 2, rows: 2 },
            { title: 'Треки', cols: 2, rows: 2 },
            { title: 'Добавить трек', cols: 2, rows: 2 },
          ];
        }
        if (breakpoints[Breakpoints.Handset]) {
          return [
            { title: 'Подписчики', cols: 2, rows: 2 },
            { title: 'Треки', cols: 2, rows: 2 },
            { title: 'Добавить трек', cols: 2, rows: 2 },
          ];
        }

        return [
          { title: 'Подписчики', cols: 2, rows: 2 },
          { title: 'Треки', cols: 2, rows: 2 },
          { title: 'Добавить трек', cols: 2, rows: 2 },
        ];
      }
      )
    );
}
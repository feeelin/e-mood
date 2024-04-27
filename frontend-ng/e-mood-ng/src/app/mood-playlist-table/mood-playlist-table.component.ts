import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { MatTable } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MoodPlaylistTableDataSource, MoodPlaylistTableItem } from './mood-playlist-table-datasource';

@Component({
  selector: 'app-mood-playlist-table',
  templateUrl: './mood-playlist-table.component.html',
  styleUrl: './mood-playlist-table.component.less'
})
export class MoodPlaylistTableComponent implements AfterViewInit {
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatTable) table!: MatTable<MoodPlaylistTableItem>;
  dataSource = new MoodPlaylistTableDataSource();

  /** Columns displayed in the table. Columns IDs can be added, removed, or reordered. */
  displayedColumns = ['id', 'name'];

  ngAfterViewInit(): void {
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
    this.table.dataSource = this.dataSource;
  }
}

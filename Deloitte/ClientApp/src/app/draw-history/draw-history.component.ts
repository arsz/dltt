import { Component, ViewChild, AfterViewInit,OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Guid } from "guid-typescript";
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from '../../environments/environment';

@Component({
  selector: 'app-draw-history',
  styleUrls: ['draw-history.component.css'],
  templateUrl: './draw-history.component.html'
})
export class DrawHistoryComponent implements OnInit  {
  displayedColumns: string[] = ['created', 'firstNumber', 'secondNumber', 'thirdNumber', 'fourthNumber', 'fifthNumber'];
  dataSource: MatTableDataSource<DrawHistory> = new MatTableDataSource<DrawHistory>();
  http: HttpClient;

  constructor(http: HttpClient) {
    this.http = http;
  }
  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;

  ngOnInit() {
    this.http.get<DrawHistory[]>(environment.apiUrl + 'history/draw-by-date').subscribe(result => {
      this.dataSource = new MatTableDataSource<DrawHistory>(result);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;

      if (this.dataSource.paginator) {
        this.dataSource.paginator.firstPage();
      }
    }, error => console.error(error));
  }

}

export interface DrawHistory {
  id?: Guid;
  firstNumber?: number;
  secondNumber?: number;
  thirdNumber?: number;
  fourthNumber?: number;
  fifthNumber?: number;
  created: Date;
}

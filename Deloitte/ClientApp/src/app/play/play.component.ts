import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { DrawHistory } from '../draw-history/draw-history.component';
import { environment } from '../../environments/environment';

@Component({
  selector: 'app-play-component',
  templateUrl: './play.component.html'
})
export class PlayComponent {
  public drawText: string = "Draw";
  public latestNumbers: string = "";

  private http: HttpClient;

  constructor(http: HttpClient) {
    this.http = http;
  }

  letsDraw() {

    const newDraw = this.getNewDraws();
    this.http.post<DrawHistory>(environment.apiUrl + 'play/draw-lottary', newDraw).subscribe(result => {
      if (result) {
        this.drawText = "Draw again";
        this.latestNumbers = result.firstNumber + ', ' + result.secondNumber + ', ' + result.thirdNumber + ', ' + result.fourthNumber + ', ' + result.fifthNumber;
      }
    }, error => console.error(error));
  }

  private getNewDraws() : DrawHistory{
    const randoms = new Array<number>(5);

    for (var i = 0; i < randoms.length; i++) {

      let same = true;
      while (same) {
        var rand = this.randomInteger(1, 50);
        same = randoms.includes(rand);
      }

      randoms[i] = rand;
    }

    const newDraw: DrawHistory = {
      firstNumber: randoms[0],
      secondNumber: randoms[1],
      thirdNumber: randoms[2],
      fourthNumber: randoms[3],
      fifthNumber: randoms[4],
      created: new Date()
    };

    return newDraw;
  }

  private randomInteger(min: number, max: number) : number{
    return Math.floor(Math.random() * (max - min + 1)) + min;
  } 
}

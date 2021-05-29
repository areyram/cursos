import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nums',
  templateUrl: './nums.component.html',
  styleUrls: ['./nums.component.scss'],
})
export class NumsComponent implements OnInit {
  ngOnInit(): void {}
  
  data: number[] = [];
  add() {
    this.data.push(Math.round(Math.random() * 1000));
  }
  sub() {
    this.data.shift();
  }
}

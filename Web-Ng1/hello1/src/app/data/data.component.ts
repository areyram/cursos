import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-data',
  templateUrl: './data.component.html',
  styleUrls: ['./data.component.scss'],
})
export class DataComponent implements OnInit {
  constructor() {}

  ngOnInit(): void {}

  nums: number[] = [123, 234];

  add() {
    this.nums.push(Math.round(Math.random() * 100));
  }
  del() {
    this.nums.shift();
  }
}

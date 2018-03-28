import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-alert',
  templateUrl: './alert.component.html',
  styleUrls: ['./alert.component.css']
})
export class AlertComponent implements OnInit {

  constructor() { }
  
  ngOnInit() {
  }
  message:string ='';
  alerts:[{Id:number,message:string}]=[{Id:1,message:"Alert1 Raised"}];
  onCreateAlert(){
    this.alerts.push({Id:this.alerts.length+1,message:this.message})
  }
}

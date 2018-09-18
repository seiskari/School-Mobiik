import { Component, OnInit } from '@angular/core';
import { ISchoolUser } from './model/school-user';
import { ApplicationDataService } from '../../services/application-data.service';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  User = <ISchoolUser>{};

  constructor() { }

  ngOnInit() {
    
  }
 

  LogIn() {

    console.log(this.User);
    
  }
}

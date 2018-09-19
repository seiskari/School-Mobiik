import { Component, OnInit } from '@angular/core';
import { ISchoolUser } from './model/school-user';
import { ApplicationDataService } from '../../services/application-data.service';
import { SchoolUserHttpService } from '../services/httpService/school-user-http.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit { 

  User = <ISchoolUser>{};

  constructor(private schoolUserHttpService: SchoolUserHttpService) { }

  ngOnInit() {
    
  }
 

  LogIn() {

    this.schoolUserHttpService.PostUser(this.User).subscribe(
      data => {
        console.log(data),
        this.User = data
      }
    )

    console.log(this.User);
    
  };
}

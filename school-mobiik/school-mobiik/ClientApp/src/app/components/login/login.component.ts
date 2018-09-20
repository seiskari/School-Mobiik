import { Component, OnInit } from '@angular/core';
import { ISchoolUser } from './model/school-user';
import { ApplicationDataService } from '../../services/application-data.service';
import { SchoolUserHttpService } from '../services/httpService/school-user-http.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit { 

  User = <ISchoolUser>{};
  currentUser = <ISchoolUser>{};
  constructor(private schoolUserHttpService: SchoolUserHttpService, private router: Router) { }

  ngOnInit() {
    
  }
 

  LogIn() {

    this.schoolUserHttpService.PostUser(this.User).subscribe(
      data => {
        console.log(data),
          this.User = data
        if (data == null) {
          alert('El usuario o la contraseña son incorrectos');
        }

      }
     
    )


    
  };

  buscarCursos(termino: string) {
    console.log(termino);
    this.router.navigate(['/buscar', termino]);
  }
}

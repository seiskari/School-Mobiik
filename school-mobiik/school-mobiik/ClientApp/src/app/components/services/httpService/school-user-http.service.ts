import { Injectable } from '@angular/core';
import { ISchoolUser } from '../../login/model/school-user';
import { HttpClient, HttpHeaders } from '@angular/common/http';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};


@Injectable({
  providedIn: 'root'
})
export class SchoolUserHttpService {


  private schoolUserUrl = 'http://localhost:38237/api/SchoolUser';  // URL to web api

  constructor(private http: HttpClient) { }

  GetUsers() {
    return this.http.get<ISchoolUser[]>(this.schoolUserUrl);
  }

  GetTeacher(SchoolUserId: number) {
    const url = `${this.schoolUserUrl}/${SchoolUserId}`;
    return this.http.get<ISchoolUser>(url)
  }

  UpdateUser(schoolUser: ISchoolUser) {
    return this.http.put(this.schoolUserUrl, schoolUser, httpOptions)
  }

  PostUser(schoolUser: ISchoolUser) {
    return this.http.post(this.schoolUserUrl, schoolUser);
  }

  DeleteUser(schoolUserId: number) {
    return this.http.delete(this.schoolUserUrl + '/' + schoolUserId);
  }
  
}

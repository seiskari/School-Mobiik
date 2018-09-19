import { Component } from '@angular/core';
import { Router } from '@angular/router'

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
  
})
export class NavMenuComponent {
  isExpanded = false;

  constructor(private router: Router) {}

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  buscarCursos(termino: string) {
    console.log(termino);
    // this.router.navigate(['/buscar', termino]);
  }
}

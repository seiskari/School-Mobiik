import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { CursosComponent } from './components/cursos/cursos.component';
import { CursoComponent } from './components/curso/curso.component';
import { BuscarCursosComponent } from './components/buscar-cursos/buscar-cursos.component';
import { CounterComponent } from './components/counter/counter.component';
import { FetchDataComponent } from './components/fetch-data/fetch-data.component';

const ROUTES: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'course', component: CursosComponent },
  { path: 'course/:id', component: CursoComponent },
  { path: 'buscar/:termino', component: BuscarCursosComponent },
  { path: 'counter', component: CounterComponent },
  { path: 'fetch-data', component: FetchDataComponent },


  { path: '**', pathMatch:'full',redirectTo:'home'}
];

export const APP_ROUTING = RouterModule.forRoot(ROUTES);

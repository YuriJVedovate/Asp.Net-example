import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EleicaoComponent } from './views/eleicao/eleicao.component';

const routes: Routes = [
  {
    path : '',
    component: EleicaoComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

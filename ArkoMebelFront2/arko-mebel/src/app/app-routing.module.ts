import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { KuhinniComponent } from './components/kuhinni/kuhinni.component';
import { MehmonxonaComponent } from './components/mehmonxona/mehmonxona.component';
import { YotoqxonaComponent } from './components/yotoqxona/yotoqxona.component';

const routes: Routes = [
  {path:'',component:KuhinniComponent},
  {path:'kuhinni',component:KuhinniComponent},
  {path:'mehmonxona',component:MehmonxonaComponent},
  {path:'yotoqxona',component:YotoqxonaComponent}
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

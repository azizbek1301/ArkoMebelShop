import { Routes } from '@angular/router';
import { NavbarComponent } from './pages/navbar/navbar.component';
import { KuhnniComponent } from './pages/kuhnni/kuhnni.component';

export const routes: Routes = [
    {path: "navbar", component: NavbarComponent},
    {path:"kuhnni",component:KuhnniComponent}
];

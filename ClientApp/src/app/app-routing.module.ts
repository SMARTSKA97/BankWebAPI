import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BankComponent } from './bank/bank.component';
import { BranchComponent } from './branch/branch.component';
import { MonitorComponent } from './monitor/monitor.component';

const routes: Routes = [
  {path:"bank",component:BankComponent},
  {path:"branch",component:BranchComponent},
  {path:"monitor",component:MonitorComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

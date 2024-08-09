import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { BankModule } from './bank/bank.module';
import { BranchModule } from './branch/branch.module';
import { MonitorModule } from './monitor/monitor.module';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: 'banks', loadChildren: () => BankModule },
  { path: 'branches', loadChildren: () => BranchModule },
  { path: 'monitor', loadChildren: () => MonitorModule },
  { path: '', redirectTo: '/banks', pathMatch: 'full' }
];

@NgModule({
  declarations: [AppComponent],
  imports: [BrowserModule, RouterModule.forRoot(routes)],
  bootstrap: [AppComponent]
})
export class AppModule {}

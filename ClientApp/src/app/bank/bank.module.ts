import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BankComponent } from './bank.component';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

const routes: Routes = [{ path: '', component: BankComponent }];

@NgModule({
  declarations: [BankComponent],
  imports: [CommonModule, HttpClientModule, RouterModule.forChild(routes)],
})
export class BankModule {}

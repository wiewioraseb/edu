import { Component, OnInit } from '@angular/core';
import { ComponentName, RedirectStateService } from '../../../redirect-state/redirect-state.service';
import { UserDetailModel } from './model/user-detail.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login-detail',
  templateUrl: './login-detail.component.html',
  styleUrls: ['./login-detail.component.css']
})
export class LoginDetailComponent implements OnInit {

  model = new UserDetailModel('', '', '');

  constructor(
    private redirectStateService: RedirectStateService,
    private router: Router,
  ) { }

  ngOnInit() {
  }

  onClickSubmit() {
    this.redirectStateService.setNavigateState(ComponentName.SelectGroup, true);
    this.router.navigate(['/' + ComponentName.SelectGroup]);
  }
}

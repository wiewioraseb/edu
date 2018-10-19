import { Component, OnInit } from '@angular/core';
import { RedirectStateService } from '../../../redirect-state/redirect-state.service';

@Component({
  selector: 'app-login-detail',
  templateUrl: './login-detail.component.html',
  styleUrls: ['./login-detail.component.css']
})
export class LoginDetailComponent implements OnInit {

  constructor(private redirectStateService: RedirectStateService) { }

  ngOnInit() {
    console.log('login detail > redirectStateService: ' + this.redirectStateService.getState());
  }

}

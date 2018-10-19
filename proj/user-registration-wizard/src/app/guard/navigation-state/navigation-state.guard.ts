import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { ComponentName, RedirectStateService } from '../../redirect-state/redirect-state.service';

@Injectable({
  providedIn: 'root'
})
export class NavigationStateGuard implements CanActivate {

  constructor(
    private router: Router,
    private redirectStateService: RedirectStateService
  ) {
  }

  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {

    const nextUrl = next.url[0].path;

    switch (nextUrl) {
      case (ComponentName.LoginDetail): {
        return this.redirectStateService.canNavigate(ComponentName.LoginDetail);
      }
      case (ComponentName.SelectGroup): {
        return this.redirectStateService.canNavigate(ComponentName.SelectGroup);
      }
      case (ComponentName.AddAvatar): {
        return this.redirectStateService.canNavigate(ComponentName.AddAvatar);
      }
      case (ComponentName.FormSubmit): {
        return this.redirectStateService.canNavigate(ComponentName.FormSubmit);
      }
      default:
        return true;
    }
  }
}

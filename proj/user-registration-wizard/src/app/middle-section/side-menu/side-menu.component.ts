import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { filter } from 'rxjs/operators';

@Component({
  selector: 'app-side-menu',
  templateUrl: './side-menu.component.html',
  styleUrls: ['./side-menu.component.css']
})
export class SideMenuComponent implements OnInit {

  @ViewChild('varMenuList')
  menuList: ElementRef;

  constructor(
    private router: Router,
  ) { }

  ngOnInit() {
    this.router.events.pipe(filter(event => event instanceof NavigationEnd))
      .subscribe((event: NavigationEnd) => {
        this.colorActiveDot(event);
      });
  }

  private colorActiveDot(event: NavigationEnd) {
    this.menuList.nativeElement.querySelectorAll('.menu-list > .menu-list-element > span')
      .forEach(e => e.style.color = 'gray');

    const idElementName = event.url.replace(/\//g, '');
    this.menuList.nativeElement.querySelector('#' + idElementName + '_circle').style.color = 'lawngreen';
  }

  navigateToQuery(path: string) {
    this.router.navigate(['/' + path]);
  }
}

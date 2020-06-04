import { MediaMatcher } from "@angular/cdk/layout";
import { ChangeDetectorRef, Component } from "@angular/core";
import { MatDialog } from "@angular/material/dialog";
import { LoginComponent } from "./_modules/login/login.component";
import { SignupComponent } from "./_modules/signup/signup.component";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.scss"],
})
export class AppComponent {
  mobileQuery: MediaQueryList;

  private _mobileQueryListener: () => void;

  constructor(
    changeDetectorRef: ChangeDetectorRef,
    media: MediaMatcher,
    private readonly dialog: MatDialog
  ) {
    this.mobileQuery = media.matchMedia("(max-width: 600px)");
    this._mobileQueryListener = () => changeDetectorRef.detectChanges();
    this.mobileQuery.addListener(this._mobileQueryListener);
  }

  ngOnDestroy(): void {
    this.mobileQuery.removeListener(this._mobileQueryListener);
  }

  onClickOpenLoginDialog() {
    this.dialog.open(LoginComponent);
  }

  onClickOpenSignupDialog() {
    this.dialog.open(SignupComponent);
  }
}

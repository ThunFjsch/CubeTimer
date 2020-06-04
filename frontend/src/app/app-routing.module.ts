import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { StatisticsPageComponent } from "./_pages/statistics-page/statistics-page.component";
import { TimerPageComponent } from "./_pages/timer-page/timer-page.component";

const routes: Routes = [
  {
    path: "",
    redirectTo: "/timer",
    pathMatch: "full",
  },
  {
    path: "timer",
    component: TimerPageComponent,
  },
  {
    path: "statistics",
    component: StatisticsPageComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}

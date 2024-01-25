import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ZakazComponent } from './zakaz.component';

describe('ZakazComponent', () => {
  let component: ZakazComponent;
  let fixture: ComponentFixture<ZakazComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ZakazComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ZakazComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

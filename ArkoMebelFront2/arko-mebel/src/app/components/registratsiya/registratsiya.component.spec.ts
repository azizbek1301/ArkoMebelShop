import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistratsiyaComponent } from './registratsiya.component';

describe('RegistratsiyaComponent', () => {
  let component: RegistratsiyaComponent;
  let fixture: ComponentFixture<RegistratsiyaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [RegistratsiyaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(RegistratsiyaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KommentariyaComponent } from './kommentariya.component';

describe('KommentariyaComponent', () => {
  let component: KommentariyaComponent;
  let fixture: ComponentFixture<KommentariyaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [KommentariyaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(KommentariyaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

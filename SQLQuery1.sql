create table pet_detail (
	pet_id int identity (1,1),
	owner_name varchar(100) not null,
	pet_type varchar(100) not null,
	pet_name varchar (100) not null,
	pet_age int not null,
	contact_number int not null,
	price decimal(7,2) not null,
	gender varchar (100) not null,
	pet_description varchar (1000) ,
	pet_image varbinary (MAX) not null,
	pet_status int default 0,
	constraint pk1 primary key (pet_id)

);

create table adopter (
	AName varchar(100) not null,
	Age int not null,
	Phone_Number varchar (100) not null,
	Email_Address varchar (100) not null,
	City varchar (100) not null,
	Town varchar (100) not null,
	Street_no int not null,
	House_no int not null,
    number_of_children int default 0,
    has_other_pets bit default 0,
    home_type varchar(50) check (home_type IN ('House', 'Apartment', 'Farm', 'Other')),
    home_status varchar(50) check (home_status IN ('Own', 'Rent')),
    reason_for_adoption text not null,
	income decimal(7,2) not null,
	constraint pk2 primary key (AName)


);

create table application_form (
	Application_ID int identity (1,1),
	AName varchar (100) not null,
	pet_id int not null,
	application_date date not null default getdate(),
	application_status bit default 0,
	constraint pk3 primary key (Application_ID),
	constraint fk1 foreign key (pet_id) references pet_detail(pet_id),
	constraint fk2 foreign key (AName) references adopter(AName)

);
drop table pet_detail;
drop table application_form;
drop table adopter;
select * from pet_detail;
select * from adopter;
select * from application_form;

select ad.AName as adopter_name, ad.Age as adopter_age, ad.Phone_Number as adopter_number,
ad.Email_Address as adopter_email, ad.City as adopter_city, ad.Town as adopter_town, 
ad.Street_no as adopter_street, ad.House_no as adopter_house, ad.number_of_children as adopter_children,
ad.has_other_pets as adopter_pets, ad.home_type as adopter_homeType,
ad.home_status as adopter_homeStatus, ad.reason_for_adoption as adopter_reason,
ad.income as adopter_income, 
a.Application_ID as AID,
a.application_date as aDate,
a.application_status as Status,
p.pet_name as PetName, p.pet_id as PID

--select p.pet_name, a.AName, p.pet_id, a.application_date, a.application_status , ad.Town
from application_form as a 
join pet_detail as p 
on a.pet_id = p.pet_id
join adopter as ad
on a.AName = ad.AName;


select ad.AName as adopter_name, ad.Age as adopter_age, ad.Phone_Number as adopter_number,ad.Email_Address as adopter_email, ad.City as adopter_city, ad.Town as adopter_town, ad.Street_no as adopter_street, ad.House_no as adopter_house, ad.number_of_children as adopter_children,ad.has_other_pets as adopter_pets, ad.home_type as adopter_homeType,ad.home_status as adopter_homeStatus, ad.reason_for_adoption as adopter_reason,ad.income as adopter_income, a.Application_ID as AID,a.application_date as aDate,a.application_status as Status,p.pet_name as PetName, p.pet_id as PID from application_form as a join pet_detail as p on a.pet_id = p.pet_id join adopter as ad on a.AName = ad.AName;



-- For treatment 

create table Disease (
    D_id int identity(1,1) primary key,
    D_name varchar(100) not null,
    D_description varchar(1000),
    Solution1 varchar(1000),
    Solution2 varchar(1000),
    Solution3 varchar(1000),
    Solution4 varchar(1000)
);

insert into Disease (D_name, D_description, Solution1, Solution2, Solution3, Solution4) VALUES
('Fleas', 'Fleas are tiny parasites that live on the skin and feed on blood, causing excessive itching, redness, hair loss, and discomfort in pets.',
 'Use an apple cider vinegar and water spray to repel fleas.',
 'Bathe the pet with lemon-infused water.',
 'Wash pet bedding in hot water weekly.',
 'Comb the pet''s fur daily with a flea comb.'),

('Ticks', 'Ticks are external parasites that attach to the skin and can transmit diseases such as Lyme disease and ehrlichiosis.',
 'Remove ticks gently using tweezers and disinfect the area.',
 'Use diluted eucalyptus oil as a natural tick repellent.',
 'Keep the yard clean to reduce tick habitat.',
 'Apply neem oil on the pet''s fur.'),

('Worms', 'Intestinal worms like roundworms, tapeworms, and hookworms can cause weight loss, diarrhea, and bloated stomach in pets.',
 'Feed pumpkin seeds as a natural dewormer.',
 'Add grated carrots to the pet''s meal.',
 'Use coconut oil to support digestive health.',
 'Keep the living area clean and free from feces.'),

('Ear Infection', 'Ear infections are caused by bacteria or yeast and can lead to scratching, head shaking, odor, and redness in the ear canal.',
 'Clean ears with vet-approved cleaner and cotton.',
 'Apply a warm compress to soothe pain.',
 'Keep ears dry after bathing or swimming.',
 'Use coconut oil drops to reduce inflammation.'),

('Diarrhea', 'Diarrhea in pets can result from sudden diet changes, food allergies, stress, or infections, leading to dehydration and discomfort.',
 'Feed a bland diet of boiled chicken and rice.',
 'Avoid dairy and treats for a few days.',
 'Provide plenty of fresh water.',
 'Add probiotics to the pet''s meal.'),

('Constipation', 'Constipation occurs when pets have difficulty passing stool due to dehydration, low-fiber diet, or lack of exercise.',
 'Add pumpkin puree to the diet for fiber.',
 'Encourage physical activity and walks.',
 'Ensure access to clean drinking water.',
 'Massage the belly gently.'),

('Dry Skin', 'Dry and flaky skin in pets may be caused by allergies, poor diet, or environmental conditions, leading to scratching and irritation.',
 'Apply coconut oil on dry patches.',
 'Use oatmeal-based pet shampoo.',
 'Add omega-3 supplements to the diet.',
 'Keep the pet hydrated.'),

('Hot Spots', 'Hot spots are localized areas of skin inflammation and infection caused by excessive licking, biting, or moisture.',
 'Clean area with antiseptic spray.',
 'Trim fur around the hot spot.',
 'Apply aloe vera gel to soothe.',
 'Prevent licking by using a cone collar.'),

('Allergies', 'Pets can develop allergies to food, pollen, dust, or fleas, leading to sneezing, scratching, and red, irritated skin.',
 'Give oatmeal baths to relieve itchiness.',
 'Feed hypoallergenic diet.',
 'Use HEPA air filters at home.',
 'Wipe paws after walks.'),

('Obesity', 'Obesity in pets increases the risk of diabetes, heart disease, and joint problems, often caused by overeating and lack of exercise.',
 'Switch to low-calorie, high-fiber food.',
 'Provide regular daily exercise.',
 'Avoid table scraps and treats.',
 'Use slow-feeding bowls.'),

('Kennel Cough', 'A highly contagious respiratory condition in dogs that causes a dry hacking cough, often contracted in boarding facilities.',
 'Use honey to soothe the throat.',
 'Keep the pet in a humid environment.',
 'Avoid exposure to smoke and cold air.',
 'Ensure good ventilation indoors.'),

('Urinary Tract Infection', 'UTIs are bacterial infections in the bladder or urinary tract, leading to frequent urination, pain, and blood in urine.',
 'Encourage frequent urination with clean water.',
 'Add cranberry powder to food.',
 'Feed wet food for hydration.',
 'Keep litter box clean (for cats).'),

('Dental Disease', 'Gum infections and plaque buildup can cause bad breath, pain, and tooth loss in pets if dental hygiene is ignored.',
 'Brush pet''s teeth daily with pet-safe toothpaste.',
 'Offer dental chews or bones.',
 'Feed crunchy kibble instead of wet food.',
 'Use coconut oil for gum massage.'),

('Parvovirus', 'A highly contagious viral disease in dogs that causes severe vomiting, bloody diarrhea, and can be fatal if untreated.',
 'Hydrate with electrolyte solution.',
 'Keep the pet warm and clean.',
 'Feed bland food under vet advice.',
 'Ensure quiet resting area.'),

('Canine Distemper', 'A serious viral illness that affects the respiratory, gastrointestinal, and nervous systems of dogs, often deadly.',
 'Provide soft and easily digestible food.',
 'Keep the pet warm and isolated.',
 'Offer bone broth for nutrition.',
 'Clean eyes and nose discharge gently.'),

('Feline Upper Respiratory Infection', 'A common illness in cats caused by viruses and bacteria, leading to sneezing, nasal discharge, and eye infections.',
 'Use steam therapy to ease congestion.',
 'Clean eyes and nose regularly.',
 'Feed strong-smelling wet food to encourage appetite.',
 'Add lysine supplements to food.'),

('Arthritis', 'Arthritis causes joint inflammation and pain in older pets, making it difficult for them to walk, run, or climb stairs.',
 'Use orthopedic pet bedding.',
 'Apply warm compress on joints.',
 'Add glucosamine supplements to food.',
 'Massage joints gently.'),

('Skin Mites', 'Mites are microscopic parasites that burrow into the skin or hair follicles, causing intense itching, hair loss, and skin crusts.',
 'Bathe with anti-parasitic shampoo.',
 'Apply apple cider vinegar rinse.',
 'Use neem oil topically.',
 'Wash bedding frequently.'),

('Anxiety', 'Pet anxiety is a behavioral issue leading to excessive barking, chewing, or urination, often triggered by separation or loud noises.',
 'Play calming music at home.',
 'Use lavender oil diffusers (safe distance).',
 'Offer comfort toys or blankets.',
 'Keep a routine schedule.'),

('Eye Infections', 'Eye infections in pets cause redness, discharge, squinting, and discomfort, often due to bacteria, dust, or injury.',
 'Clean eyes with saline solution.',
 'Use warm tea bags as compress.',
 'Trim fur around the eyes.',
 'Avoid dusty areas.');


 create table Tips (
    Tip_ID int identity(1,1) PRIMARY KEY,
    Tip_Name varchar(100) NOT NULL,
    Description varchar(1000),
    Pet_Type varchar(50)        
);

insert into Tips (Tip_Name, Description, Pet_Type) values
('House Training Your Dog', 'Establish a routine for bathroom breaks, reward positive behavior, and be patient for consistent results.', 'Dog'),
('Brushing a Cat''s Fur', 'Use a soft-bristle brush and groom your cat regularly to prevent mats and reduce shedding.', 'Cat'),
('Feeding Rabbits Properly', 'Provide a balanced diet including hay, leafy greens, and a limited amount of pellets.', 'Rabbit'),
('Basic Obedience Commands', 'Teach commands like sit, stay, and come using treats and positive reinforcement.', 'Dog'),
('Litter Training a Kitten', 'Keep the litter box clean and place the kitten in the box after meals to build a habit.', 'Cat'),
('Trimming Dog Nails Safely', 'Use a pet nail clipper and trim just the tips to avoid hitting the quick.', 'Dog'),
('Hydration for Birds', 'Ensure clean water is available at all times; change daily to avoid contamination.', 'Bird'),
('Introducing New Pets to Each Other', 'Use slow, supervised introductions and keep them in separate spaces at first.', 'All'),
('Safe Toys for Chewing', 'Provide non-toxic, durable toys to satisfy chewing needs and avoid damage to furniture.', 'Dog'),
('Managing Pet Anxiety', 'Create a safe space, stick to routines, and use calming music or pheromone diffusers.', 'All'),
('Dealing with Shedding', 'Brush your pet regularly and use a de-shedding tool to minimize loose fur.', 'Dog'),
('Building Trust with a New Pet', 'Give space, use treats, and be patient during the first few weeks.', 'All'),
('Cleaning the Litter Box', 'Scoop daily and wash the litter box weekly with mild soap and water.', 'Cat'),
('Preventing Feather Plucking', 'Provide mental stimulation and proper diet to avoid stress in birds.', 'Bird'),
('Exercise Ideas for Indoor Cats', 'Use climbing trees, laser pointers, and interactive toys to keep cats active.', 'Cat'),
('Proper Hamster Habitat Setup', 'Include tunnels, a wheel, bedding, and hiding spots in the cage.', 'Hamster'),
('Training Your Dog to Walk on a Leash', 'Use short walks, gentle commands, and treats to encourage good leash behavior.', 'Dog'),
('Daily Dental Care for Dogs', 'Brush with dog-safe toothpaste or offer dental treats and chew toys.', 'Dog'),
('Preparing for Vet Visits', 'Familiarize your pet with carriers or car rides to reduce stress.', 'All'),
('Cleaning Bird Cages', 'Change liners daily and disinfect the cage weekly to prevent infections.', 'Bird'),
('Keeping Rabbits Entertained', 'Provide chew toys, cardboard boxes, and tunnels for play.', 'Rabbit'),
('Weight Management in Pets', 'Measure food portions and engage pets in regular play or walks.', 'All');


create table Users (
    Username varchar(100) primary key,
    Password varchar(100) not null,
    Name varchar(100),
    Email varchar(150)
);

insert into Users (Username, Password, Name, Email) values
('fahid0088', 'P@k1st@n', 'Fahid Imran', 'fahid@example.com'),
('hanzlah0088', 'P@k1st@n', 'Hanzalah Shah', 'hanzalah@example.com'),
('awais0088', 'P@k1st@n', 'Awais Khan', 'awais@example.com'),
('adam0088', 'P@k1st@n', 'Adam Smith', 'adam@example.com'),
('abdullah0088', 'P@k1st@n', 'Abdullah Noor', 'abdullah@example.com'),
('ibraheem0088', 'P@k1st@n', 'Ibraheem Ali', 'ibraheem@example.com');

select *
from users;

create table petproduct (
    product_id int identity(1,1) primary key,
    product_name varchar(100) not null,
    description varchar(1000),
    pet_type varchar(50) not null,
    price decimal(8, 2) not null,
    quantity int not null check (quantity >=0),
    product_image varbinary (max) not null  
);

select product_id ,product_name ,description ,pet_type ,price ,quantity ,product_image 
from petproduct;
-- drop table cartitem;
-- drop table petproduct;
create table cart (
    cart_id int identity(1,1) primary key,
    userid varchar(100) not null, 
    foreign key (userid) references users(username)
);


create table cartitem (
    cartitem_id int identity(1,1) primary key,
    cart_id int not null,
    product_id int not null,
    quantity int not null,
    added_at datetime default getdate(),
    foreign key (cart_id) references cart(cart_id),
    foreign key (product_id) references petproduct(product_id)
);

select *
from cartitem;

delete from application_form;
delete from pet_detail;
delete from cartitem;
delete from cart;
delete from petproduct;
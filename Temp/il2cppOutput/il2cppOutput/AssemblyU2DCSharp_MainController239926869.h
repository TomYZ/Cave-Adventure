#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t4012695102;
// Buttons[]
struct ButtonsU5BU5D_t1843995132;
// UnityEngine.Rigidbody2D
struct Rigidbody2D_t3632243084;
// UnityEngine.Animator
struct Animator_t792326996;
// UnityEngine.SpriteRenderer
struct SpriteRenderer_t2223784725;
// InputState
struct InputState_t3369051911;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"
#include "UnityEngine_UnityEngine_Vector33525329789.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// MainController
struct  MainController_t239926869  : public MonoBehaviour_t3012272455
{
public:
	// System.Single MainController::maxspeedUpDown
	float ___maxspeedUpDown_2;
	// System.Single MainController::speed
	float ___speed_3;
	// UnityEngine.GameObject MainController::player
	GameObject_t4012695102 * ___player_4;
	// UnityEngine.GameObject MainController::sheild
	GameObject_t4012695102 * ___sheild_5;
	// System.Single MainController::health
	float ___health_6;
	// Buttons[] MainController::input
	ButtonsU5BU5D_t1843995132* ___input_7;
	// System.Boolean MainController::isboost
	bool ___isboost_8;
	// System.Single MainController::boostDuration
	float ___boostDuration_9;
	// UnityEngine.Rigidbody2D MainController::rb2d
	Rigidbody2D_t3632243084 * ___rb2d_10;
	// UnityEngine.Animator MainController::anim
	Animator_t792326996 * ___anim_11;
	// UnityEngine.SpriteRenderer MainController::healthBar
	SpriteRenderer_t2223784725 * ___healthBar_12;
	// UnityEngine.Vector3 MainController::healthScale
	Vector3_t3525329789  ___healthScale_13;
	// System.Boolean MainController::ShowThisGUI
	bool ___ShowThisGUI_14;
	// InputState MainController::inputState
	InputState_t3369051911 * ___inputState_15;
	// System.Single MainController::InitX
	float ___InitX_16;
	// System.Single MainController::t
	float ___t_17;
	// System.Single MainController::velocity
	float ___velocity_18;
	// System.Int32 MainController::start
	int32_t ___start_19;
	// System.Int32 MainController::score
	int32_t ___score_20;

public:
	inline static int32_t get_offset_of_maxspeedUpDown_2() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___maxspeedUpDown_2)); }
	inline float get_maxspeedUpDown_2() const { return ___maxspeedUpDown_2; }
	inline float* get_address_of_maxspeedUpDown_2() { return &___maxspeedUpDown_2; }
	inline void set_maxspeedUpDown_2(float value)
	{
		___maxspeedUpDown_2 = value;
	}

	inline static int32_t get_offset_of_speed_3() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___speed_3)); }
	inline float get_speed_3() const { return ___speed_3; }
	inline float* get_address_of_speed_3() { return &___speed_3; }
	inline void set_speed_3(float value)
	{
		___speed_3 = value;
	}

	inline static int32_t get_offset_of_player_4() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___player_4)); }
	inline GameObject_t4012695102 * get_player_4() const { return ___player_4; }
	inline GameObject_t4012695102 ** get_address_of_player_4() { return &___player_4; }
	inline void set_player_4(GameObject_t4012695102 * value)
	{
		___player_4 = value;
		Il2CppCodeGenWriteBarrier(&___player_4, value);
	}

	inline static int32_t get_offset_of_sheild_5() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___sheild_5)); }
	inline GameObject_t4012695102 * get_sheild_5() const { return ___sheild_5; }
	inline GameObject_t4012695102 ** get_address_of_sheild_5() { return &___sheild_5; }
	inline void set_sheild_5(GameObject_t4012695102 * value)
	{
		___sheild_5 = value;
		Il2CppCodeGenWriteBarrier(&___sheild_5, value);
	}

	inline static int32_t get_offset_of_health_6() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___health_6)); }
	inline float get_health_6() const { return ___health_6; }
	inline float* get_address_of_health_6() { return &___health_6; }
	inline void set_health_6(float value)
	{
		___health_6 = value;
	}

	inline static int32_t get_offset_of_input_7() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___input_7)); }
	inline ButtonsU5BU5D_t1843995132* get_input_7() const { return ___input_7; }
	inline ButtonsU5BU5D_t1843995132** get_address_of_input_7() { return &___input_7; }
	inline void set_input_7(ButtonsU5BU5D_t1843995132* value)
	{
		___input_7 = value;
		Il2CppCodeGenWriteBarrier(&___input_7, value);
	}

	inline static int32_t get_offset_of_isboost_8() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___isboost_8)); }
	inline bool get_isboost_8() const { return ___isboost_8; }
	inline bool* get_address_of_isboost_8() { return &___isboost_8; }
	inline void set_isboost_8(bool value)
	{
		___isboost_8 = value;
	}

	inline static int32_t get_offset_of_boostDuration_9() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___boostDuration_9)); }
	inline float get_boostDuration_9() const { return ___boostDuration_9; }
	inline float* get_address_of_boostDuration_9() { return &___boostDuration_9; }
	inline void set_boostDuration_9(float value)
	{
		___boostDuration_9 = value;
	}

	inline static int32_t get_offset_of_rb2d_10() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___rb2d_10)); }
	inline Rigidbody2D_t3632243084 * get_rb2d_10() const { return ___rb2d_10; }
	inline Rigidbody2D_t3632243084 ** get_address_of_rb2d_10() { return &___rb2d_10; }
	inline void set_rb2d_10(Rigidbody2D_t3632243084 * value)
	{
		___rb2d_10 = value;
		Il2CppCodeGenWriteBarrier(&___rb2d_10, value);
	}

	inline static int32_t get_offset_of_anim_11() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___anim_11)); }
	inline Animator_t792326996 * get_anim_11() const { return ___anim_11; }
	inline Animator_t792326996 ** get_address_of_anim_11() { return &___anim_11; }
	inline void set_anim_11(Animator_t792326996 * value)
	{
		___anim_11 = value;
		Il2CppCodeGenWriteBarrier(&___anim_11, value);
	}

	inline static int32_t get_offset_of_healthBar_12() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___healthBar_12)); }
	inline SpriteRenderer_t2223784725 * get_healthBar_12() const { return ___healthBar_12; }
	inline SpriteRenderer_t2223784725 ** get_address_of_healthBar_12() { return &___healthBar_12; }
	inline void set_healthBar_12(SpriteRenderer_t2223784725 * value)
	{
		___healthBar_12 = value;
		Il2CppCodeGenWriteBarrier(&___healthBar_12, value);
	}

	inline static int32_t get_offset_of_healthScale_13() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___healthScale_13)); }
	inline Vector3_t3525329789  get_healthScale_13() const { return ___healthScale_13; }
	inline Vector3_t3525329789 * get_address_of_healthScale_13() { return &___healthScale_13; }
	inline void set_healthScale_13(Vector3_t3525329789  value)
	{
		___healthScale_13 = value;
	}

	inline static int32_t get_offset_of_ShowThisGUI_14() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___ShowThisGUI_14)); }
	inline bool get_ShowThisGUI_14() const { return ___ShowThisGUI_14; }
	inline bool* get_address_of_ShowThisGUI_14() { return &___ShowThisGUI_14; }
	inline void set_ShowThisGUI_14(bool value)
	{
		___ShowThisGUI_14 = value;
	}

	inline static int32_t get_offset_of_inputState_15() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___inputState_15)); }
	inline InputState_t3369051911 * get_inputState_15() const { return ___inputState_15; }
	inline InputState_t3369051911 ** get_address_of_inputState_15() { return &___inputState_15; }
	inline void set_inputState_15(InputState_t3369051911 * value)
	{
		___inputState_15 = value;
		Il2CppCodeGenWriteBarrier(&___inputState_15, value);
	}

	inline static int32_t get_offset_of_InitX_16() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___InitX_16)); }
	inline float get_InitX_16() const { return ___InitX_16; }
	inline float* get_address_of_InitX_16() { return &___InitX_16; }
	inline void set_InitX_16(float value)
	{
		___InitX_16 = value;
	}

	inline static int32_t get_offset_of_t_17() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___t_17)); }
	inline float get_t_17() const { return ___t_17; }
	inline float* get_address_of_t_17() { return &___t_17; }
	inline void set_t_17(float value)
	{
		___t_17 = value;
	}

	inline static int32_t get_offset_of_velocity_18() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___velocity_18)); }
	inline float get_velocity_18() const { return ___velocity_18; }
	inline float* get_address_of_velocity_18() { return &___velocity_18; }
	inline void set_velocity_18(float value)
	{
		___velocity_18 = value;
	}

	inline static int32_t get_offset_of_start_19() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___start_19)); }
	inline int32_t get_start_19() const { return ___start_19; }
	inline int32_t* get_address_of_start_19() { return &___start_19; }
	inline void set_start_19(int32_t value)
	{
		___start_19 = value;
	}

	inline static int32_t get_offset_of_score_20() { return static_cast<int32_t>(offsetof(MainController_t239926869, ___score_20)); }
	inline int32_t get_score_20() const { return ___score_20; }
	inline int32_t* get_address_of_score_20() { return &___score_20; }
	inline void set_score_20(int32_t value)
	{
		___score_20 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
